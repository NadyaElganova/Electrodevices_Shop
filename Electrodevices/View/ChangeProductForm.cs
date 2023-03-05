using Electrodevices.Controller;
using Electrodevices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.View
{
    public partial class ChangeProductForm : Form
    {
        private readonly DataService _data = DataService.Instance;
        Electrodevice electrodevice;
        string fileName;
        public ChangeProductForm(Electrodevice electrodevice)
        {
            InitializeComponent();
            this.electrodevice = electrodevice;
            fileName = electrodevice.Path_Picture;

            UpdateComboBox();
        }
        private async void changeProduct_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_TextBox.Text) == true
                || string.IsNullOrWhiteSpace(category_ComboBox.Text) == true
                || string.IsNullOrWhiteSpace(country_ComboBox.Text) == true)
            {
                MessageBox.Show("Некорректный ввод!");
                return;
            } 
            Electrodevice newElectrodevice = new Electrodevice
            {
                Category = await _data.GetCategory(category_ComboBox.Text),
                Model = name_TextBox.Text,
                Price = price_NumericUpDown.Value,
                Wight = weight_NumericUpDown.Value,
                Amount_Stock = (int)stock_NumericUpDown.Value,
                Amount_Sale = (int)sale_NumericUpDown.Value,
                Amount_Defect = (int)difect_NumericUpDown.Value,
                Path_Picture = fileName,
                Date = await _data.GetDate((int)year_NumericUpDown.Value),
                Country = await _data.GetCountry(country_ComboBox.Text),
            };
            var res = await _data.ChangeElectrodevice(newElectrodevice);
            if (res == true ) MessageBox.Show("Товар был изменен!");
            await _data.RemoveElectodevice(electrodevice);
        }
        private void addPicture_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображение|*.jpg;*png";
            openFileDialog1.InitialDirectory = "D:\\Electrodevices\\Electrodevices\\bin\\ProductPicture";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                product_PictureBox.Image = Image.FromFile(fileName);
            }
        }
        private async void UpdateComboBox()
        {
            category_ComboBox.Items.Clear();
            (await _data.GetAllCategories()).ToList().ForEach(c => category_ComboBox.Items.Add(c));
            country_ComboBox.Items.Clear();
            (await _data.GetAllCountries()).ToList().ForEach(c => country_ComboBox.Items.Add(c));
        }

        private void ChangeProductForm_Load(object sender, EventArgs e)
        {
            category_ComboBox.Text = electrodevice.Category.Name;
            name_TextBox.Text = electrodevice.Model;
            price_NumericUpDown.Value = electrodevice.Price;
            weight_NumericUpDown.Value = electrodevice.Wight;
            difect_NumericUpDown.Value = electrodevice.Amount_Defect;
            sale_NumericUpDown.Value = electrodevice.Amount_Sale;
            stock_NumericUpDown.Value = electrodevice.Amount_Stock;
            year_NumericUpDown.Value = electrodevice.Date.Year;
            country_ComboBox.Text = electrodevice.Country.Name;
            product_PictureBox.Image = Image.FromFile(fileName);
        }
    }
}
