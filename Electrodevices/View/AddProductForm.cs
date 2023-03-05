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
    public partial class AddProductForm : Form
    {
        string fileName = "";
        private readonly DataService data = DataService.Instance;
        public AddProductForm()
        {
            InitializeComponent();
            UpdateComboBox();
        }

        private async void addProduct_Button_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(name_TextBox.Text) == true 
                || string.IsNullOrWhiteSpace(category_ComboBox.Text) == true
                || string.IsNullOrWhiteSpace(country_ComboBox.Text) == true)
            {
                MessageBox.Show("Некорректный ввод!");
                return;
            }
            if (fileName == "")
            {
                MessageBox.Show("Добавьте изображение товара!");
                return;
            }
            var category = await data.GetCategory(category_ComboBox.Text);
            var country = await data.GetCountry(country_ComboBox.Text);
            var year = await data.GetDate((int)year_NumericUpDown.Value);
            Electrodevice newElectrodevice = new Electrodevice()
            {
                Model = name_TextBox.Text,
                Price = price_NumericUpDown.Value,
                Wight = weight_NumericUpDown.Value,
                Amount_Stock = (int)stock_NumericUpDown.Value,
                Amount_Sale = (int)sale_NumericUpDown.Value,
                Amount_Defect = (int)difect_NumericUpDown.Value,
                Path_Picture = fileName
            };
            if (category == null || country == null || year == null)
            {                    
                if (category == null)
                {
                    Category newCategory = new Category()
                    {
                        Name = category_ComboBox.Text,
                    };
                    newCategory.Electrodevices.Add(newElectrodevice);
                    await data.AddCategory(newCategory);
                }
                if (year == null)
                {
                    Date newYear = new Date()
                    {
                        Year = (int)year_NumericUpDown.Value,
                    };
                    newYear.Electrodevices.Add(newElectrodevice);                    
                    await data.AddDate(newYear);
                }
                if (country == null)
                {
                    Country newCountry = new Country()
                    {
                        Name = country_ComboBox.Text,
                    };
                    newCountry.Electrodevices.Add(newElectrodevice);                    
                    await data.AddCountry(newCountry);
                }
            }
            if (category != null || country != null || year != null)
            {
                if (category != null) newElectrodevice.Category = category;
                if (country != null) newElectrodevice.Country = country;
                if (year != null) newElectrodevice.Date = year;   
                await data.AddElectrodevice(newElectrodevice, country, year, category);
            }                
            MessageBox.Show("Товар был добавлен!");
            category_ComboBox.Text = "";
            name_TextBox.Text = "";
            country_ComboBox.Text = "";
            product_PictureBox.Image = null;
            stock_NumericUpDown.Value = 0;
            year_NumericUpDown.Value = 2020;
            difect_NumericUpDown.Value = 0;
            sale_NumericUpDown.Value = 0;
            price_NumericUpDown.Value = 0;
            weight_NumericUpDown.Value = 0;
            UpdateComboBox();
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
            (await data.GetAllCategories()).ToList().ForEach(c => category_ComboBox.Items.Add(c));
            country_ComboBox.Items.Clear();
            (await data.GetAllCountries()).ToList().ForEach(c => country_ComboBox.Items.Add(c));
        }

    }
}
