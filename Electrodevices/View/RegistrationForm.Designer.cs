
namespace Electrodevices.View
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registration_Button = new System.Windows.Forms.Button();
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.secondName_TextBox = new System.Windows.Forms.TextBox();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancel_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registration_Button
            // 
            this.registration_Button.Location = new System.Drawing.Point(235, 380);
            this.registration_Button.Name = "registration_Button";
            this.registration_Button.Size = new System.Drawing.Size(286, 79);
            this.registration_Button.TabIndex = 0;
            this.registration_Button.Text = "Зарегистрироваться";
            this.registration_Button.UseVisualStyleBackColor = true;
            this.registration_Button.Click += new System.EventHandler(this.registration_Button_Click);
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Location = new System.Drawing.Point(235, 36);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(286, 22);
            this.firstName_TextBox.TabIndex = 1;
            // 
            // secondName_TextBox
            // 
            this.secondName_TextBox.Location = new System.Drawing.Point(235, 87);
            this.secondName_TextBox.Name = "secondName_TextBox";
            this.secondName_TextBox.Size = new System.Drawing.Size(286, 22);
            this.secondName_TextBox.TabIndex = 2;
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(235, 154);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(286, 22);
            this.login_TextBox.TabIndex = 3;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(235, 212);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(286, 22);
            this.password_TextBox.TabIndex = 4;
            // 
            // phoneNumber_MaskedTextBox
            // 
            this.phoneNumber_MaskedTextBox.Location = new System.Drawing.Point(235, 271);
            this.phoneNumber_MaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneNumber_MaskedTextBox.Name = "phoneNumber_MaskedTextBox";
            this.phoneNumber_MaskedTextBox.Size = new System.Drawing.Size(286, 22);
            this.phoneNumber_MaskedTextBox.TabIndex = 16;
            // 
            // cancel_LinkLabel
            // 
            this.cancel_LinkLabel.AutoSize = true;
            this.cancel_LinkLabel.Location = new System.Drawing.Point(706, 442);
            this.cancel_LinkLabel.Name = "cancel_LinkLabel";
            this.cancel_LinkLabel.Size = new System.Drawing.Size(59, 17);
            this.cancel_LinkLabel.TabIndex = 17;
            this.cancel_LinkLabel.TabStop = true;
            this.cancel_LinkLabel.Text = "Отмена";
            this.cancel_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancel_LinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Эл.почта";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(235, 328);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(286, 22);
            this.email_TextBox.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_LinkLabel);
            this.Controls.Add(this.phoneNumber_MaskedTextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.secondName_TextBox);
            this.Controls.Add(this.firstName_TextBox);
            this.Controls.Add(this.registration_Button);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_Button;
        private System.Windows.Forms.TextBox firstName_TextBox;
        private System.Windows.Forms.TextBox secondName_TextBox;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumber_MaskedTextBox;
        private System.Windows.Forms.LinkLabel cancel_LinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_TextBox;
    }
}