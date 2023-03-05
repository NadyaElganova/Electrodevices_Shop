
namespace Electrodevices.View
{
    partial class SearchProductForm
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
            this.sortProducts_ComboBox = new System.Windows.Forms.ComboBox();
            this.searchProduct_Button = new System.Windows.Forms.Button();
            this.sortProduct_Button = new System.Windows.Forms.Button();
            this.linq_comboBox = new System.Windows.Forms.ComboBox();
            this.allProduct_ListBox = new System.Windows.Forms.ListBox();
            this.pictureProduct_PictureBox = new System.Windows.Forms.PictureBox();
            this.betterProduct_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchLinqButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortProducts_ComboBox
            // 
            this.sortProducts_ComboBox.FormattingEnabled = true;
            this.sortProducts_ComboBox.Items.AddRange(new object[] {
            "по дате выпуска",
            "по модели",
            "по стране производства",
            "по весу",
            "по стоимости"});
            this.sortProducts_ComboBox.Location = new System.Drawing.Point(152, 13);
            this.sortProducts_ComboBox.Name = "sortProducts_ComboBox";
            this.sortProducts_ComboBox.Size = new System.Drawing.Size(355, 24);
            this.sortProducts_ComboBox.TabIndex = 1;
            // 
            // searchProduct_Button
            // 
            this.searchProduct_Button.Location = new System.Drawing.Point(513, 63);
            this.searchProduct_Button.Name = "searchProduct_Button";
            this.searchProduct_Button.Size = new System.Drawing.Size(161, 26);
            this.searchProduct_Button.TabIndex = 4;
            this.searchProduct_Button.Text = "Найти";
            this.searchProduct_Button.UseVisualStyleBackColor = true;
            this.searchProduct_Button.Click += new System.EventHandler(this.searchProduct_Button_Click);
            // 
            // sortProduct_Button
            // 
            this.sortProduct_Button.Location = new System.Drawing.Point(513, 13);
            this.sortProduct_Button.Name = "sortProduct_Button";
            this.sortProduct_Button.Size = new System.Drawing.Size(161, 26);
            this.sortProduct_Button.TabIndex = 5;
            this.sortProduct_Button.Text = "Сортировать";
            this.sortProduct_Button.UseVisualStyleBackColor = true;
            this.sortProduct_Button.Click += new System.EventHandler(this.sortProduct_Button_Click_1);
            // 
            // linq_comboBox
            // 
            this.linq_comboBox.FormattingEnabled = true;
            this.linq_comboBox.Items.AddRange(new object[] {
            "Найти среднюю стоимость ЭП",
            "Найти ЭП с ценной в заданных пределах",
            "Найти ЭП заданного производителя",
            "Найти ЭП с заданной датой выпуска",
            "Найти ЭП заданной категории",
            "Найти ЭП, чей вес находится в заданных пределах изаданного производителя",
            "Найти ЭП чья стоимость меньше заданной и от заданного производителя",
            "Найти наибольшее кол-во бракованных ЭП, поступивших из заданной страны",
            "Найти ЭП, чья стоимость выше, чем средняя стоимость ЭП заданного производителя"});
            this.linq_comboBox.Location = new System.Drawing.Point(185, 21);
            this.linq_comboBox.Name = "linq_comboBox";
            this.linq_comboBox.Size = new System.Drawing.Size(583, 24);
            this.linq_comboBox.TabIndex = 6;
            this.linq_comboBox.SelectedIndexChanged += new System.EventHandler(this.linq_comboBox_SelectedIndexChanged);
            // 
            // allProduct_ListBox
            // 
            this.allProduct_ListBox.FormattingEnabled = true;
            this.allProduct_ListBox.ItemHeight = 16;
            this.allProduct_ListBox.Location = new System.Drawing.Point(12, 286);
            this.allProduct_ListBox.Name = "allProduct_ListBox";
            this.allProduct_ListBox.Size = new System.Drawing.Size(1149, 356);
            this.allProduct_ListBox.TabIndex = 8;
            this.allProduct_ListBox.SelectedIndexChanged += new System.EventHandler(this.allProduct_ListBox_SelectedIndexChanged);
            // 
            // pictureProduct_PictureBox
            // 
            this.pictureProduct_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureProduct_PictureBox.Name = "pictureProduct_PictureBox";
            this.pictureProduct_PictureBox.Size = new System.Drawing.Size(222, 263);
            this.pictureProduct_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct_PictureBox.TabIndex = 9;
            this.pictureProduct_PictureBox.TabStop = false;
            // 
            // betterProduct_comboBox
            // 
            this.betterProduct_comboBox.FormattingEnabled = true;
            this.betterProduct_comboBox.Items.AddRange(new object[] {
            "самый дорогой",
            "самый дешевый",
            "самый популярный"});
            this.betterProduct_comboBox.Location = new System.Drawing.Point(152, 63);
            this.betterProduct_comboBox.Name = "betterProduct_comboBox";
            this.betterProduct_comboBox.Size = new System.Drawing.Size(355, 24);
            this.betterProduct_comboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сортировать";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Электроприбор";
            // 
            // searchLinqButton
            // 
            this.searchLinqButton.Location = new System.Drawing.Point(743, 81);
            this.searchLinqButton.Name = "searchLinqButton";
            this.searchLinqButton.Size = new System.Drawing.Size(165, 67);
            this.searchLinqButton.TabIndex = 13;
            this.searchLinqButton.Text = "Найти";
            this.searchLinqButton.UseVisualStyleBackColor = true;
            this.searchLinqButton.Click += new System.EventHandler(this.searchLinqButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Запросы для поиска:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.yearNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.countryComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priceToNumericUpDown);
            this.groupBox1.Controls.Add(this.priceFromNumericUpDown);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchLinqButton);
            this.groupBox1.Controls.Add(this.linq_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(247, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 159);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Год";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(199, 117);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2070,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(129, 22);
            this.yearNumericUpDown.TabIndex = 26;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Цена / Вес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(433, 114);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(233, 24);
            this.categoryComboBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Модель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Страна производства";
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(596, 51);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(233, 24);
            this.countryComboBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "с";
            // 
            // priceToNumericUpDown
            // 
            this.priceToNumericUpDown.Location = new System.Drawing.Point(525, 81);
            this.priceToNumericUpDown.Maximum = new decimal(new int[] {
            700000,
            0,
            0,
            0});
            this.priceToNumericUpDown.Name = "priceToNumericUpDown";
            this.priceToNumericUpDown.Size = new System.Drawing.Size(129, 22);
            this.priceToNumericUpDown.TabIndex = 17;
            // 
            // priceFromNumericUpDown
            // 
            this.priceFromNumericUpDown.Location = new System.Drawing.Point(355, 81);
            this.priceFromNumericUpDown.Maximum = new decimal(new int[] {
            700000,
            0,
            0,
            0});
            this.priceFromNumericUpDown.Name = "priceFromNumericUpDown";
            this.priceFromNumericUpDown.Size = new System.Drawing.Size(134, 22);
            this.priceFromNumericUpDown.TabIndex = 16;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(185, 51);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(227, 22);
            this.modelTextBox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.betterProduct_comboBox);
            this.groupBox2.Controls.Add(this.sortProducts_ComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.searchProduct_Button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sortProduct_Button);
            this.groupBox2.Location = new System.Drawing.Point(303, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 109);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // SearchProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureProduct_PictureBox);
            this.Controls.Add(this.allProduct_ListBox);
            this.Name = "SearchProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchProductForm";
            this.Load += new System.EventHandler(this.SearchProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct_PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFromNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox sortProducts_ComboBox;
        private System.Windows.Forms.Button searchProduct_Button;
        private System.Windows.Forms.Button sortProduct_Button;
        private System.Windows.Forms.ComboBox linq_comboBox;
        private System.Windows.Forms.ListBox allProduct_ListBox;
        private System.Windows.Forms.PictureBox pictureProduct_PictureBox;
        private System.Windows.Forms.ComboBox betterProduct_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchLinqButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceToNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceFromNumericUpDown;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
    }
}