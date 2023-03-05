using Electrodevices.Controller;
using Electrodevices.Model;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.View
{
    public partial class SearchProductForm : Form
    {
        private readonly DataService _data = DataService.Instance;
        AppDBContext _context;
        List<Electrodevice> electrodevices = new List<Electrodevice>();
        public SearchProductForm()
        {
            InitializeComponent();
            _context = new AppDBContext();
            sortProducts_ComboBox.SelectedIndex = 0;
            betterProduct_comboBox.SelectedIndex = 0;
            linq_comboBox.SelectedIndex = 0;
            
        }
        private void UpdatelistBox()
        {
            allProduct_ListBox.Items.Clear();
            electrodevices.ForEach(e => allProduct_ListBox.Items.Add(e));
        }
        private async void SearchProductForm_Load(object sender, EventArgs e)
        {
            allProduct_ListBox.Items.Clear();
            electrodevices = await _data.GetAllElectrodevices();
            foreach (var item in electrodevices)
            {
                allProduct_ListBox.Items.Add(item);
            }
            (await _data.GetAllCategories()).ToList().ForEach(c => categoryComboBox.Items.Add(c));
            categoryComboBox.SelectedIndex = 0;
            (await _data.GetAllCountries()).ToList().ForEach(c => countryComboBox.Items.Add(c));
            countryComboBox.SelectedIndex = 0;
        }

        private void linq_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (linq_comboBox.SelectedIndex)
            {
                case 0:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = false;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 1:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = false;
                    priceFromNumericUpDown.Enabled = true;
                    priceToNumericUpDown.Enabled = true;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 2:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = true;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 3:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = false;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = true;
                    break;
                case 4:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = false;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = true;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 5:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = true;
                    priceFromNumericUpDown.Enabled = true;
                    priceToNumericUpDown.Enabled = true;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 6:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = true;
                    priceFromNumericUpDown.Enabled = true;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 7:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = true;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
                case 8:
                    modelTextBox.Enabled = false;
                    countryComboBox.Enabled = true;
                    priceFromNumericUpDown.Enabled = false;
                    priceToNumericUpDown.Enabled = false;
                    categoryComboBox.Enabled = false;
                    yearNumericUpDown.Enabled = false;
                    break;
            }
        }

        private async void searchLinqButton_Click(object sender, EventArgs e)
        {
            electrodevices.Clear();
            string country = "";
            switch (linq_comboBox.SelectedIndex)
            {
                case 0:
                    electrodevices = await _data.GetAllElectrodevices();
                    allProduct_ListBox.Items.Clear();
                    foreach (var electrodevice in electrodevices)
                    {
                        var average = averageCost(electrodevice);
                        allProduct_ListBox.Items.Add(electrodevice +" Средняя стоимость = " + average.ToString());
                    }
                    return;
                case 1:
                    electrodevices = _context.Electrodevices.Where(p => p.Price >= priceFromNumericUpDown.Value && p.Price <= priceToNumericUpDown.Value).ToList();
                    break;
                case 2:
                    country = countryComboBox.SelectedItem.ToString();
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Country.Name == country).ToList();
                    break;
                case 3:
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Date.Year == yearNumericUpDown.Value).ToList();
                    break;
                case 4:
                    var category = categoryComboBox.SelectedItem.ToString();
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Category.Name == category).ToList();
                    break;
                case 5:
                    country = countryComboBox.SelectedItem.ToString();
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Wight >= priceFromNumericUpDown.Value && p.Wight <= priceToNumericUpDown.Value && p.Country.Name == country).ToList();
                    break;
                case 6:
                    country = countryComboBox.SelectedItem.ToString();
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Price < priceFromNumericUpDown.Value && p.Country.Name == country).ToList();
                    break;
                case 7:
                    country = countryComboBox.SelectedItem.ToString();
                    electrodevices = _context.Electrodevices.Include("Country").Include("Date").Include("Category").Where(p => p.Country.Name == country).MaxBy(p => p.Amount_Defect).ToList();
                    break;
                case 8:

                    break;
            }
            UpdatelistBox();
        }
        private decimal averageCost(Electrodevice electrodevice)
        {            
            var amountSale = electrodevice.Amount_Sale;            
            var price = electrodevice.Price;
            if (amountSale == 0 || price == 0) return 0;
            var avaragePrice = price * amountSale / amountSale;
            return avaragePrice;
        }

        private async void sortProduct_Button_Click_1(object sender, EventArgs e)
        {
            electrodevices.Clear();
            electrodevices = await _data.SortElectrodevices(sortProducts_ComboBox.SelectedIndex);
            if (electrodevices == null) return;
            UpdatelistBox();
        }

        private void allProduct_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Electrodevice electrodevice = allProduct_ListBox.SelectedItem as Electrodevice;
                if (electrodevice == null) return;
                string path = electrodevice.Path_Picture;
                pictureProduct_PictureBox.Image = Image.FromFile(path);
            }
            catch (Exception allException)
            {
                return;
            }
        }

        private void searchProduct_Button_Click(object sender, EventArgs e)
        {
            electrodevices.Clear();
            electrodevices = _data.BetterElectrodevice(betterProduct_comboBox.SelectedIndex);
            if (electrodevices == null) return;
            UpdatelistBox();
        }
    }
}
