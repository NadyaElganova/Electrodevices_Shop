
namespace Electrodevices.View
{
    partial class AuthorizationForm
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
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.enter_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registration_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.administrator_CheckBox = new System.Windows.Forms.CheckBox();
            this.load_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.load_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(180, 116);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(376, 22);
            this.login_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(180, 172);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(376, 22);
            this.password_TextBox.TabIndex = 1;
            // 
            // enter_Button
            // 
            this.enter_Button.Location = new System.Drawing.Point(230, 250);
            this.enter_Button.Name = "enter_Button";
            this.enter_Button.Size = new System.Drawing.Size(265, 70);
            this.enter_Button.TabIndex = 2;
            this.enter_Button.Text = "Войти";
            this.enter_Button.UseVisualStyleBackColor = true;
            this.enter_Button.Click += new System.EventHandler(this.enter_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // registration_LinkLabel
            // 
            this.registration_LinkLabel.AutoSize = true;
            this.registration_LinkLabel.Location = new System.Drawing.Point(548, 369);
            this.registration_LinkLabel.Name = "registration_LinkLabel";
            this.registration_LinkLabel.Size = new System.Drawing.Size(144, 17);
            this.registration_LinkLabel.TabIndex = 5;
            this.registration_LinkLabel.TabStop = true;
            this.registration_LinkLabel.Text = "Зарегистрироваться";
            this.registration_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkLabel_LinkClicked);
            // 
            // administrator_CheckBox
            // 
            this.administrator_CheckBox.AutoSize = true;
            this.administrator_CheckBox.Location = new System.Drawing.Point(272, 213);
            this.administrator_CheckBox.Name = "administrator_CheckBox";
            this.administrator_CheckBox.Size = new System.Drawing.Size(202, 21);
            this.administrator_CheckBox.TabIndex = 6;
            this.administrator_CheckBox.Text = "Войти как администратор";
            this.administrator_CheckBox.UseVisualStyleBackColor = true;
            // 
            // load_pictureBox
            // 
            this.load_pictureBox.Location = new System.Drawing.Point(272, 12);
            this.load_pictureBox.Name = "load_pictureBox";
            this.load_pictureBox.Size = new System.Drawing.Size(165, 98);
            this.load_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.load_pictureBox.TabIndex = 7;
            this.load_pictureBox.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 418);
            this.Controls.Add(this.load_pictureBox);
            this.Controls.Add(this.administrator_CheckBox);
            this.Controls.Add(this.registration_LinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.load_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button enter_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registration_LinkLabel;
        private System.Windows.Forms.CheckBox administrator_CheckBox;
        private System.Windows.Forms.PictureBox load_pictureBox;
    }
}