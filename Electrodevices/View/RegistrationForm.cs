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
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();         
        }

        private async void registration_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName_TextBox.Text) == true ||
                string.IsNullOrWhiteSpace(secondName_TextBox.Text) == true ||
                string.IsNullOrWhiteSpace(login_TextBox.Text) == true ||
                string.IsNullOrWhiteSpace(password_TextBox.Text) == true ||
                string.IsNullOrWhiteSpace(phoneNumber_MaskedTextBox.Text) == true ||
                string.IsNullOrWhiteSpace(email_TextBox.Text) == true)
            {
                MessageBox.Show("Некорректный ввод! Заполните все поля для регистрации!");
                return;
            }
            else 
            {
                User user = new User()
                {
                    FirstName = firstName_TextBox.Text,
                    LastName = secondName_TextBox.Text,
                    Phone = phoneNumber_MaskedTextBox.Text,
                    Email = email_TextBox.Text,
                    Login = login_TextBox.Text,
                    Password = password_TextBox.Text
                };
                var result = await AuthUser.Instance.AddObject(user);
                if (result == true)
                {
                    MessageBox.Show("Регистрация успешно пройдена!");
                    firstName_TextBox.Text = "";
                    secondName_TextBox.Text = "";
                    phoneNumber_MaskedTextBox.Text = "";
                    email_TextBox.Text = "";
                    login_TextBox.Text = "";
                    password_TextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Регистрация не пройдена! Что-то пошло не так!");
                    return;
                }
            }
        }

        private void cancel_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
