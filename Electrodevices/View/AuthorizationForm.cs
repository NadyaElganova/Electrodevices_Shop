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
            if (administrator_CheckBox.Checked == false)
            {
                var resultUser = (User)await AuthUser.Instance.LoginObject(login_TextBox.Text, password_TextBox.Text);
                if (resultUser != null)
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
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
                }
            }
            else
            {
                var resultAdmin = await AuthAdmin.Instance.LoginObject(login_TextBox.Text, password_TextBox.Text);
                if (resultAdmin != null)
                {
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
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
