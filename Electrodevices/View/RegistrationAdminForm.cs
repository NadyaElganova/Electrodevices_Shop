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
    public partial class RegistrationAdminForm : Form
    {
        public RegistrationAdminForm()
        {
            InitializeComponent();
        }

        private async void registration_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_TextBox.Text) == true || string.IsNullOrWhiteSpace(password_TextBox.Text) == true)
            {
                MessageBox.Show("Некорректный ввод!");
                return;
            }
            var res = await AuthAdmin.Instance.AddObject(new Administrator() { Login = login_TextBox.Text, Password = password_TextBox.Text });
            if (res == true)
            {
                MessageBox.Show("Регистрация успешно пройдена");
            }
            else
            {
                MessageBox.Show("Регистрация не пройдена! Что-то пошло не так!");
            }
            login_TextBox.Text = "";
            password_TextBox.Text = "";
            return;
        }

        private void cancel_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
