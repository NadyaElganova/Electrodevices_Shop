using Electrodevices.Controller.Authorization;
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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();

        }

        private async void enter_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_TextBox.Text) == true ||
                string.IsNullOrWhiteSpace(password_TextBox.Text) == true)
            {
                MessageBox.Show("Некорректный ввод!");
                return;
            }
            enter_Button.Enabled = false;
            load_pictureBox.Image = Image.FromFile("D:\\Electrodevices\\Electrodevices\\bin\\ProductPicture\\Загрузка.gif");
            if (administrator_CheckBox.Checked == false)
            {
                var resultUser = (User)await AuthUser.Instance.LoginObject(login_TextBox.Text, password_TextBox.Text);
                if (resultUser != null)
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
                    enter_Button.Enabled = true;
                    load_pictureBox.Image = null;
                    this.Visible = false;
                    if (new UserForm(resultUser).ShowDialog() == DialogResult.OK)
                    {
                    }
                    this.Visible = true;
                }
                else
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
                    load_pictureBox.Image = null;
                    enter_Button.Enabled = true;
                }
            }
            else
            {
                var resultAdmin = await AuthAdmin.Instance.LoginObject(login_TextBox.Text, password_TextBox.Text);
                if (resultAdmin != null)
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
                    enter_Button.Enabled = true;
                    load_pictureBox.Image = null;
                    this.Visible = false;
                    if (new AdminForm().ShowDialog() == DialogResult.OK)
                    { 
                    }
                    this.Visible = true;
                }
                else
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
                    load_pictureBox.Image = null;
                    enter_Button.Enabled = true;
                }
            }
        }

        private void registration_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            if (new RegistrationForm().ShowDialog() == DialogResult.OK)
            { 

            }
            this.Visible = true;
        }

    }
}
