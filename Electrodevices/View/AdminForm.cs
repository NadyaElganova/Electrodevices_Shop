using Electrodevices.Controller;
using Electrodevices.Model;
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
    public partial class AdminForm : Form
    {
        private readonly DataService _data = DataService.Instance;
        public AdminForm()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void addProduct_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new AddProductForm().ShowDialog() == DialogResult.OK)
            { 
            }
            this.Visible = true;
            UpdateListBox();
        }

        private void changeProduct_Button_Click(object sender, EventArgs e)
        {
            Electrodevice electrodevice = allProduct_ListBox.SelectedItem as Electrodevice;
            if (electrodevice == null)
            {
                MessageBox.Show("Товар не выбран!");
                return;
            }
            this.Visible = false;
            if (new ChangeProductForm(electrodevice).ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
            UpdateListBox();
        }

        private async void deleteProduct_Button_Click(object sender, EventArgs e)
        {
            Electrodevice electrodevice = allProduct_ListBox.SelectedItem as Electrodevice;
            if (electrodevice == null) return;
            var res = await _data.RemoveElectodevice(electrodevice);
            if (res == false) MessageBox.Show("Неудалось удалить!");
            UpdateListBox();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            if (new SearchProductForm().ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
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
        public async void UpdateListBox()
        {
            allProduct_ListBox.Items.Clear();
            var electrodevices = await _data.GetAllElectrodevices();
            foreach (var item in electrodevices)
            {
                allProduct_ListBox.Items.Add(item);
            }
        }

        private void registrationAdmin_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            if (new RegistrationAdminForm().ShowDialog() == DialogResult.OK)
            {                
            }
            this.Visible = true;
        }
    }
}
