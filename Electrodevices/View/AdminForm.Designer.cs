
namespace Electrodevices.View
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.changeProduct_Button = new System.Windows.Forms.Button();
            this.addProduct_Button = new System.Windows.Forms.Button();
            this.deleteProduct_Button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureProduct_PictureBox = new System.Windows.Forms.PictureBox();
            this.allProduct_ListBox = new System.Windows.Forms.ListBox();
            this.registrationAdmin_LinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(518, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Склад";
            // 
            // changeProduct_Button
            // 
            this.changeProduct_Button.Location = new System.Drawing.Point(644, 384);
            this.changeProduct_Button.Name = "changeProduct_Button";
            this.changeProduct_Button.Size = new System.Drawing.Size(342, 76);
            this.changeProduct_Button.TabIndex = 6;
            this.changeProduct_Button.Text = "Изменить товар";
            this.changeProduct_Button.UseVisualStyleBackColor = true;
            this.changeProduct_Button.Click += new System.EventHandler(this.changeProduct_Button_Click);
            // 
            // addProduct_Button
            // 
            this.addProduct_Button.Location = new System.Drawing.Point(644, 466);
            this.addProduct_Button.Name = "addProduct_Button";
            this.addProduct_Button.Size = new System.Drawing.Size(342, 76);
            this.addProduct_Button.TabIndex = 7;
            this.addProduct_Button.Text = "Добавить товар";
            this.addProduct_Button.UseVisualStyleBackColor = true;
            this.addProduct_Button.Click += new System.EventHandler(this.addProduct_Button_Click);
            // 
            // deleteProduct_Button
            // 
            this.deleteProduct_Button.Location = new System.Drawing.Point(644, 548);
            this.deleteProduct_Button.Name = "deleteProduct_Button";
            this.deleteProduct_Button.Size = new System.Drawing.Size(342, 76);
            this.deleteProduct_Button.TabIndex = 8;
            this.deleteProduct_Button.Text = "Удалить товар";
            this.deleteProduct_Button.UseVisualStyleBackColor = true;
            this.deleteProduct_Button.Click += new System.EventHandler(this.deleteProduct_Button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(748, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Найти товар на складе";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureProduct_PictureBox
            // 
            this.pictureProduct_PictureBox.Location = new System.Drawing.Point(37, 349);
            this.pictureProduct_PictureBox.Name = "pictureProduct_PictureBox";
            this.pictureProduct_PictureBox.Size = new System.Drawing.Size(506, 275);
            this.pictureProduct_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct_PictureBox.TabIndex = 10;
            this.pictureProduct_PictureBox.TabStop = false;
            // 
            // allProduct_ListBox
            // 
            this.allProduct_ListBox.FormattingEnabled = true;
            this.allProduct_ListBox.ItemHeight = 16;
            this.allProduct_ListBox.Location = new System.Drawing.Point(37, 46);
            this.allProduct_ListBox.Name = "allProduct_ListBox";
            this.allProduct_ListBox.Size = new System.Drawing.Size(1007, 292);
            this.allProduct_ListBox.TabIndex = 11;
            this.allProduct_ListBox.SelectedIndexChanged += new System.EventHandler(this.allProduct_ListBox_SelectedIndexChanged);
            // 
            // registrationAdmin_LinkLabel
            // 
            this.registrationAdmin_LinkLabel.AutoSize = true;
            this.registrationAdmin_LinkLabel.Location = new System.Drawing.Point(690, 627);
            this.registrationAdmin_LinkLabel.Name = "registrationAdmin_LinkLabel";
            this.registrationAdmin_LinkLabel.Size = new System.Drawing.Size(276, 17);
            this.registrationAdmin_LinkLabel.TabIndex = 12;
            this.registrationAdmin_LinkLabel.TabStop = true;
            this.registrationAdmin_LinkLabel.Text = "Зарегистрироваться как администратор";
            this.registrationAdmin_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationAdmin_LinkLabel_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 661);
            this.Controls.Add(this.registrationAdmin_LinkLabel);
            this.Controls.Add(this.allProduct_ListBox);
            this.Controls.Add(this.pictureProduct_PictureBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.deleteProduct_Button);
            this.Controls.Add(this.addProduct_Button);
            this.Controls.Add(this.changeProduct_Button);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeProduct_Button;
        private System.Windows.Forms.Button addProduct_Button;
        private System.Windows.Forms.Button deleteProduct_Button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureProduct_PictureBox;
        private System.Windows.Forms.ListBox allProduct_ListBox;
        private System.Windows.Forms.LinkLabel registrationAdmin_LinkLabel;
    }
}