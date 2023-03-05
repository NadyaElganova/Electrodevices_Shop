
namespace Electrodevices.View
{
    partial class RegistrationAdminForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.registration_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Логин";
            // 
            // cancel_LinkLabel
            // 
            this.cancel_LinkLabel.AutoSize = true;
            this.cancel_LinkLabel.Location = new System.Drawing.Point(706, 418);
            this.cancel_LinkLabel.Name = "cancel_LinkLabel";
            this.cancel_LinkLabel.Size = new System.Drawing.Size(59, 17);
            this.cancel_LinkLabel.TabIndex = 31;
            this.cancel_LinkLabel.TabStop = true;
            this.cancel_LinkLabel.Text = "Отмена";
            this.cancel_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancel_LinkLabel_LinkClicked);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(235, 188);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(286, 22);
            this.password_TextBox.TabIndex = 29;
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(235, 130);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(286, 22);
            this.login_TextBox.TabIndex = 28;
            // 
            // registration_Button
            // 
            this.registration_Button.Location = new System.Drawing.Point(235, 280);
            this.registration_Button.Name = "registration_Button";
            this.registration_Button.Size = new System.Drawing.Size(286, 79);
            this.registration_Button.TabIndex = 25;
            this.registration_Button.Text = "Зарегистрироваться";
            this.registration_Button.UseVisualStyleBackColor = true;
            this.registration_Button.Click += new System.EventHandler(this.registration_Button_Click);
            // 
            // RegistrationAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_LinkLabel);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.registration_Button);
            this.Name = "RegistrationAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel cancel_LinkLabel;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.Button registration_Button;
    }
}