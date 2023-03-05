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
using System.Data.Entity;


namespace Electrodevices.View
{
    public partial class UserForm : Form
    {
        User user;
        private readonly DataService _data = DataService.Instance;
        List<Electrodevice> electrodevices = new List<Electrodevice>();
        private readonly BasketService _basket = BasketService.Instance;
        public UserForm(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private async void UpdateComboBox()
        {
            categories_ComboBox.Items.Add("Все товары");
            (await _data.GetAllCategories()).ForEach(c => categories_ComboBox.Items.Add(c));
            categories_ComboBox.SelectedIndex = 0;
        }
        public async void UpdateListBoxShop()
        {
            allProducts_ListBox.Items.Clear();
            electrodevices = await _data.GetAllElectrodevices();
            foreach (var item in electrodevices)
            {
                allProducts_ListBox.Items.Add(item);
            }
        }
        public async void UpdateListBoxBasket()
        {
            basketProducts_ListBox.Items.Clear();
            var result = await _basket.GetElectrodevicesInBasket(user.Id);
            if (result == null) return;
            foreach (var item in result)
            {
                basketProducts_ListBox.Items.Add(item);
            }
            summa_Label.Text = await SummaBasket();
        }
        private async Task<string> SummaBasket()
        {
            decimal summa = 0;
            var result = await _basket.GetElectrodevicesInBasket(user.Id);
            foreach (var item in result)
            {
                summa += item.Price;
            }
            return summa.ToString();
        }
        private async void addProductBasket_Button_Click(object sender, EventArgs e)
        {
            Electrodevice electrodevice = allProducts_ListBox.SelectedItem as Electrodevice;
            if (electrodevice == null)
            {
                MessageBox.Show("Товар не выбран!");
                return;
            }
            var product = allProducts_ListBox.SelectedItem as Electrodevice;
            var res = await _basket.AddProductInBasket(user, product);
            if (res == true)
            {
                UpdateListBoxBasket();
            }
            else MessageBox.Show("Ошибка добавления!");
        }

        private async void buyProduct_Button_Click(object sender, EventArgs e)
        {
            if (basketProducts_ListBox.Items.Count == 0) return;
            await _basket.BuyElectrodevice(user.Id);
            UpdateListBoxBasket();
            UpdateListBoxShop();
        }

        private async void categories_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categories_ComboBox.SelectedIndex == 0)
            {
                UpdateListBoxShop();
            } 
            else 
            {
                var category = categories_ComboBox.SelectedItem.ToString();
                electrodevices = (await _data.GetAllElectrodevices()).Where(el => el.Category.Name == category).ToList();
                allProducts_ListBox.Items.Clear();
                foreach (var item in electrodevices)
                {
                    allProducts_ListBox.Items.Add(item);
                }
            }
        }

        private void allProducts_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Electrodevice electrodeviceList = allProducts_ListBox.SelectedItem as Electrodevice;
                if (electrodeviceList == null) return;
                string path = electrodeviceList.Path_Picture;
                pictureProduct_PictureBox.Image = Image.FromFile(path);
            }
            catch (Exception allException)
            {
                return;
            }
        }

        private async void deleteProduct_Button_Click(object sender, EventArgs e)
        {
            Electrodevice electrodevice = basketProducts_ListBox.SelectedItem as Electrodevice;
            if (electrodevice == null) return;
            var res = await _basket.RemoveProductBasket(electrodevice);
            UpdateListBoxBasket();
        }

        private void searchProduct_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            if (new SearchProductForm().ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
            nameLabel.Text = user.FirstName;

            UpdateListBoxBasket();
        }
    }
}
