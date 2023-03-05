
namespace Electrodevices.View
{
    partial class AddProductForm
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
            this.addProduct_Button = new System.Windows.Forms.Button();
            this.category_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weight_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.difect_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sale_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.stock_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.country_ComboBox = new System.Windows.Forms.ComboBox();
            this.addPicture_Button = new System.Windows.Forms.Button();
            this.product_PictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.year_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difect_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addProduct_Button
            // 
            this.addProduct_Button.Location = new System.Drawing.Point(309, 565);
            this.addProduct_Button.Name = "addProduct_Button";
            this.addProduct_Button.Size = new System.Drawing.Size(313, 83);
            this.addProduct_Button.TabIndex = 0;
            this.addProduct_Button.Text = "Добавить товар";
            this.addProduct_Button.UseVisualStyleBackColor = true;
            this.addProduct_Button.Click += new System.EventHandler(this.addProduct_Button_Click);
            // 
            // category_ComboBox
            // 
            this.category_ComboBox.FormattingEnabled = true;
            this.category_ComboBox.Location = new System.Drawing.Point(309, 30);
            this.category_ComboBox.Name = "category_ComboBox";
            this.category_ComboBox.Size = new System.Drawing.Size(313, 24);
            this.category_ComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(309, 75);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(313, 22);
            this.name_TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Марка";
            // 
            // price_NumericUpDown
            // 
            this.price_NumericUpDown.Location = new System.Drawing.Point(309, 114);
            this.price_NumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.price_NumericUpDown.Name = "price_NumericUpDown";
            this.price_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.price_NumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес";
            // 
            // weight_NumericUpDown
            // 
            this.weight_NumericUpDown.Location = new System.Drawing.Point(309, 156);
            this.weight_NumericUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.weight_NumericUpDown.Name = "weight_NumericUpDown";
            this.weight_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.weight_NumericUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во брака";
            // 
            // difect_NumericUpDown
            // 
            this.difect_NumericUpDown.Location = new System.Drawing.Point(309, 195);
            this.difect_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.difect_NumericUpDown.Name = "difect_NumericUpDown";
            this.difect_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.difect_NumericUpDown.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Кол-во продаж";
            // 
            // sale_NumericUpDown
            // 
            this.sale_NumericUpDown.Location = new System.Drawing.Point(309, 246);
            this.sale_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sale_NumericUpDown.Name = "sale_NumericUpDown";
            this.sale_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.sale_NumericUpDown.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кол-во на складе";
            // 
            // stock_NumericUpDown
            // 
            this.stock_NumericUpDown.Location = new System.Drawing.Point(309, 290);
            this.stock_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stock_NumericUpDown.Name = "stock_NumericUpDown";
            this.stock_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.stock_NumericUpDown.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Год";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Страна производства";
            // 
            // country_ComboBox
            // 
            this.country_ComboBox.FormattingEnabled = true;
            this.country_ComboBox.Location = new System.Drawing.Point(309, 383);
            this.country_ComboBox.Name = "country_ComboBox";
            this.country_ComboBox.Size = new System.Drawing.Size(313, 24);
            this.country_ComboBox.TabIndex = 17;
            // 
            // addPicture_Button
            // 
            this.addPicture_Button.Location = new System.Drawing.Point(138, 457);
            this.addPicture_Button.Name = "addPicture_Button";
            this.addPicture_Button.Size = new System.Drawing.Size(151, 64);
            this.addPicture_Button.TabIndex = 20;
            this.addPicture_Button.Text = "Добавить картинку";
            this.addPicture_Button.UseVisualStyleBackColor = true;
            this.addPicture_Button.Click += new System.EventHandler(this.addPicture_Button_Click);
            // 
            // product_PictureBox
            // 
            this.product_PictureBox.Location = new System.Drawing.Point(309, 417);
            this.product_PictureBox.Name = "product_PictureBox";
            this.product_PictureBox.Size = new System.Drawing.Size(313, 142);
            this.product_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PictureBox.TabIndex = 19;
            this.product_PictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // year_NumericUpDown
            // 
            this.year_NumericUpDown.Location = new System.Drawing.Point(309, 338);
            this.year_NumericUpDown.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.year_NumericUpDown.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.year_NumericUpDown.Name = "year_NumericUpDown";
            this.year_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.year_NumericUpDown.TabIndex = 21;
            this.year_NumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.year_NumericUpDown);
            this.Controls.Add(this.addPicture_Button);
            this.Controls.Add(this.product_PictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.country_ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stock_NumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sale_NumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.difect_NumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weight_NumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_NumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_ComboBox);
            this.Controls.Add(this.addProduct_Button);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difect_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProduct_Button;
        private System.Windows.Forms.ComboBox category_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown price_NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weight_NumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown difect_NumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sale_NumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown stock_NumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox country_ComboBox;
        private System.Windows.Forms.Button addPicture_Button;
        private System.Windows.Forms.PictureBox product_PictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown year_NumericUpDown;
    }
}