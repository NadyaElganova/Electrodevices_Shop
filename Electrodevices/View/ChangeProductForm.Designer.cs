
namespace Electrodevices.View
{
    partial class ChangeProductForm
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
            this.changeProduct_Button = new System.Windows.Forms.Button();
            this.addPicture_Button = new System.Windows.Forms.Button();
            this.product_PictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.country_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stock_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sale_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.difect_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.weight_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.price_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.category_ComboBox = new System.Windows.Forms.ComboBox();
            this.year_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difect_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // changeProduct_Button
            // 
            this.changeProduct_Button.Location = new System.Drawing.Point(278, 588);
            this.changeProduct_Button.Name = "changeProduct_Button";
            this.changeProduct_Button.Size = new System.Drawing.Size(313, 83);
            this.changeProduct_Button.TabIndex = 21;
            this.changeProduct_Button.Text = "Изменить товар";
            this.changeProduct_Button.UseVisualStyleBackColor = true;
            this.changeProduct_Button.Click += new System.EventHandler(this.changeProduct_Button_Click);
            // 
            // addPicture_Button
            // 
            this.addPicture_Button.Location = new System.Drawing.Point(107, 482);
            this.addPicture_Button.Name = "addPicture_Button";
            this.addPicture_Button.Size = new System.Drawing.Size(151, 64);
            this.addPicture_Button.TabIndex = 42;
            this.addPicture_Button.Text = "Изменить картинку";
            this.addPicture_Button.UseVisualStyleBackColor = true;
            this.addPicture_Button.Click += new System.EventHandler(this.addPicture_Button_Click);
            // 
            // product_PictureBox
            // 
            this.product_PictureBox.Location = new System.Drawing.Point(278, 442);
            this.product_PictureBox.Name = "product_PictureBox";
            this.product_PictureBox.Size = new System.Drawing.Size(313, 142);
            this.product_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PictureBox.TabIndex = 41;
            this.product_PictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Страна производства";
            // 
            // country_ComboBox
            // 
            this.country_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_ComboBox.FormattingEnabled = true;
            this.country_ComboBox.Location = new System.Drawing.Point(278, 408);
            this.country_ComboBox.Name = "country_ComboBox";
            this.country_ComboBox.Size = new System.Drawing.Size(313, 24);
            this.country_ComboBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Год";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Кол-во на складе";
            // 
            // stock_NumericUpDown
            // 
            this.stock_NumericUpDown.Location = new System.Drawing.Point(278, 315);
            this.stock_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stock_NumericUpDown.Name = "stock_NumericUpDown";
            this.stock_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.stock_NumericUpDown.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Кол-во продаж";
            // 
            // sale_NumericUpDown
            // 
            this.sale_NumericUpDown.Location = new System.Drawing.Point(278, 271);
            this.sale_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sale_NumericUpDown.Name = "sale_NumericUpDown";
            this.sale_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.sale_NumericUpDown.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Кол-во брака";
            // 
            // difect_NumericUpDown
            // 
            this.difect_NumericUpDown.Location = new System.Drawing.Point(278, 220);
            this.difect_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.difect_NumericUpDown.Name = "difect_NumericUpDown";
            this.difect_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.difect_NumericUpDown.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Вес";
            // 
            // weight_NumericUpDown
            // 
            this.weight_NumericUpDown.Location = new System.Drawing.Point(278, 181);
            this.weight_NumericUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.weight_NumericUpDown.Name = "weight_NumericUpDown";
            this.weight_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.weight_NumericUpDown.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Цена";
            // 
            // price_NumericUpDown
            // 
            this.price_NumericUpDown.Location = new System.Drawing.Point(278, 139);
            this.price_NumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.price_NumericUpDown.Name = "price_NumericUpDown";
            this.price_NumericUpDown.Size = new System.Drawing.Size(313, 22);
            this.price_NumericUpDown.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Марка";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(278, 100);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(313, 22);
            this.name_TextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Категория";
            // 
            // category_ComboBox
            // 
            this.category_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_ComboBox.FormattingEnabled = true;
            this.category_ComboBox.Location = new System.Drawing.Point(278, 55);
            this.category_ComboBox.Name = "category_ComboBox";
            this.category_ComboBox.Size = new System.Drawing.Size(313, 24);
            this.category_ComboBox.TabIndex = 23;
            // 
            // year_NumericUpDown
            // 
            this.year_NumericUpDown.Location = new System.Drawing.Point(278, 363);
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
            this.year_NumericUpDown.TabIndex = 43;
            this.year_NumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChangeProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 708);
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
            this.Controls.Add(this.changeProduct_Button);
            this.Name = "ChangeProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeProductForm";
            this.Load += new System.EventHandler(this.ChangeProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difect_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeProduct_Button;
        private System.Windows.Forms.Button addPicture_Button;
        private System.Windows.Forms.PictureBox product_PictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox country_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown stock_NumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sale_NumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown difect_NumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weight_NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown price_NumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_ComboBox;
        private System.Windows.Forms.NumericUpDown year_NumericUpDown;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}