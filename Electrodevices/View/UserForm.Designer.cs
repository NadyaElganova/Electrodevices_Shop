
namespace Electrodevices.View
{
    partial class UserForm
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
            this.addProductBasket_Button = new System.Windows.Forms.Button();
            this.buyProduct_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.summa_Label = new System.Windows.Forms.Label();
            this.searchProduct_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.categories_ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.allProducts_ListBox = new System.Windows.Forms.ListBox();
            this.pictureProduct_PictureBox = new System.Windows.Forms.PictureBox();
            this.basketProducts_ListBox = new System.Windows.Forms.ListBox();
            this.deleteProduct_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(487, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = ", Добро пожаловать в магазин \"ЭлектроприборовПлюс\"!";
            // 
            // addProductBasket_Button
            // 
            this.addProductBasket_Button.Location = new System.Drawing.Point(976, 358);
            this.addProductBasket_Button.Name = "addProductBasket_Button";
            this.addProductBasket_Button.Size = new System.Drawing.Size(346, 68);
            this.addProductBasket_Button.TabIndex = 3;
            this.addProductBasket_Button.Text = "Добавить в корзину";
            this.addProductBasket_Button.UseVisualStyleBackColor = true;
            this.addProductBasket_Button.Click += new System.EventHandler(this.addProductBasket_Button_Click);
            // 
            // buyProduct_Button
            // 
            this.buyProduct_Button.Location = new System.Drawing.Point(976, 586);
            this.buyProduct_Button.Name = "buyProduct_Button";
            this.buyProduct_Button.Size = new System.Drawing.Size(346, 68);
            this.buyProduct_Button.TabIndex = 5;
            this.buyProduct_Button.Text = "Оформить заказ";
            this.buyProduct_Button.UseVisualStyleBackColor = true;
            this.buyProduct_Button.Click += new System.EventHandler(this.buyProduct_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваша корзина";
            // 
            // summa_Label
            // 
            this.summa_Label.AutoSize = true;
            this.summa_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summa_Label.Location = new System.Drawing.Point(977, 554);
            this.summa_Label.Name = "summa_Label";
            this.summa_Label.Size = new System.Drawing.Size(62, 18);
            this.summa_Label.TabIndex = 7;
            this.summa_Label.Text = "______";
            // 
            // searchProduct_LinkLabel
            // 
            this.searchProduct_LinkLabel.AutoSize = true;
            this.searchProduct_LinkLabel.Location = new System.Drawing.Point(1077, 326);
            this.searchProduct_LinkLabel.Name = "searchProduct_LinkLabel";
            this.searchProduct_LinkLabel.Size = new System.Drawing.Size(161, 17);
            this.searchProduct_LinkLabel.TabIndex = 8;
            this.searchProduct_LinkLabel.TabStop = true;
            this.searchProduct_LinkLabel.Text = "Найти товар на складе";
            this.searchProduct_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchProduct_LinkLabel_LinkClicked);
            // 
            // categories_ComboBox
            // 
            this.categories_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_ComboBox.FormattingEnabled = true;
            this.categories_ComboBox.Location = new System.Drawing.Point(110, 91);
            this.categories_ComboBox.Name = "categories_ComboBox";
            this.categories_ComboBox.Size = new System.Drawing.Size(289, 24);
            this.categories_ComboBox.TabIndex = 9;
            this.categories_ComboBox.SelectedIndexChanged += new System.EventHandler(this.categories_ComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вид товара";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(412, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // allProducts_ListBox
            // 
            this.allProducts_ListBox.FormattingEnabled = true;
            this.allProducts_ListBox.ItemHeight = 16;
            this.allProducts_ListBox.Location = new System.Drawing.Point(12, 126);
            this.allProducts_ListBox.Name = "allProducts_ListBox";
            this.allProducts_ListBox.Size = new System.Drawing.Size(958, 292);
            this.allProducts_ListBox.TabIndex = 12;
            this.allProducts_ListBox.SelectedIndexChanged += new System.EventHandler(this.allProducts_ListBox_SelectedIndexChanged);
            // 
            // pictureProduct_PictureBox
            // 
            this.pictureProduct_PictureBox.Location = new System.Drawing.Point(976, 126);
            this.pictureProduct_PictureBox.Name = "pictureProduct_PictureBox";
            this.pictureProduct_PictureBox.Size = new System.Drawing.Size(364, 197);
            this.pictureProduct_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct_PictureBox.TabIndex = 13;
            this.pictureProduct_PictureBox.TabStop = false;
            // 
            // basketProducts_ListBox
            // 
            this.basketProducts_ListBox.FormattingEnabled = true;
            this.basketProducts_ListBox.ItemHeight = 16;
            this.basketProducts_ListBox.Location = new System.Drawing.Point(12, 453);
            this.basketProducts_ListBox.Name = "basketProducts_ListBox";
            this.basketProducts_ListBox.Size = new System.Drawing.Size(958, 292);
            this.basketProducts_ListBox.TabIndex = 14;
            // 
            // deleteProduct_Button
            // 
            this.deleteProduct_Button.Location = new System.Drawing.Point(980, 671);
            this.deleteProduct_Button.Name = "deleteProduct_Button";
            this.deleteProduct_Button.Size = new System.Drawing.Size(342, 63);
            this.deleteProduct_Button.TabIndex = 15;
            this.deleteProduct_Button.Text = "Удалить товар";
            this.deleteProduct_Button.UseVisualStyleBackColor = true;
            this.deleteProduct_Button.Click += new System.EventHandler(this.deleteProduct_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1067, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "руб.";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 765);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteProduct_Button);
            this.Controls.Add(this.basketProducts_ListBox);
            this.Controls.Add(this.pictureProduct_PictureBox);
            this.Controls.Add(this.allProducts_ListBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categories_ComboBox);
            this.Controls.Add(this.searchProduct_LinkLabel);
            this.Controls.Add(this.summa_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyProduct_Button);
            this.Controls.Add(this.addProductBasket_Button);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProductBasket_Button;
        private System.Windows.Forms.Button buyProduct_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label summa_Label;
        private System.Windows.Forms.LinkLabel searchProduct_LinkLabel;
        private System.Windows.Forms.ComboBox categories_ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox allProducts_ListBox;
        private System.Windows.Forms.PictureBox pictureProduct_PictureBox;
        private System.Windows.Forms.ListBox basketProducts_ListBox;
        private System.Windows.Forms.Button deleteProduct_Button;
        private System.Windows.Forms.Label label2;
    }
}