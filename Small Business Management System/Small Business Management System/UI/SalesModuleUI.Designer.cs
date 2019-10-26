﻿namespace Small_Business_Management_System
{
    partial class SalesModuleUI
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loyaltyPointTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.addCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.submit = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loyaltyPointTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // loyaltyPointTextBox
            // 
            this.loyaltyPointTextBox.Location = new System.Drawing.Point(98, 98);
            this.loyaltyPointTextBox.Name = "loyaltyPointTextBox";
            this.loyaltyPointTextBox.Size = new System.Drawing.Size(152, 20);
            this.loyaltyPointTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loyalty Point";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(98, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.addCustomerBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(98, 27);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(152, 21);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.ValueMember = "LoyaltyPoint";
            // 
            // addCustomerBindingSource
            // 
            this.addCustomerBindingSource.DataSource = typeof(Small_Business_Management_System.AddCustomer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.totalAmountTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(36, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.addCategoryBindingSource, "CategoryName", true));
            this.categoryComboBox.DataSource = this.addCategoryBindingSource;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(100, 23);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(150, 21);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.ValueMember = "CategoryCode";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // addCategoryBindingSource
            // 
            this.addCategoryBindingSource.DataSource = typeof(Small_Business_Management_System.AddCategory);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(119, 260);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(98, 212);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(152, 20);
            this.totalAmountTextBox.TabIndex = 15;
            this.totalAmountTextBox.Text = "             <View>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total (Tk.)";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(98, 175);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(152, 20);
            this.mrpTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MRP (Tk.)";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(98, 139);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(152, 20);
            this.quantityTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantity";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(100, 102);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(152, 20);
            this.availableQuantityTextBox.TabIndex = 9;
            this.availableQuantityTextBox.Text = "             <View>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available Quantity";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(100, 61);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(152, 21);
            this.productComboBox.TabIndex = 4;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // addProductBindingSource
            // 
            this.addProductBindingSource.DataSource = typeof(Small_Business_Management_System.AddProduct);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.submit);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.showDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(364, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 404);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(224, 368);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 25;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 334);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "             <View>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Payable AMount (Tk.)";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(181, 297);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(152, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "             <View>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Discount Amount (Tk.)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(181, 261);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(152, 20);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "             <View>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Discount (%)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(181, 224);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(152, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "             <View>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Grand Total";
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(17, 27);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(421, 187);
            this.showDataGridView.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Search By";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(424, 455);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sales Code";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(424, 478);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Date";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(424, 501);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 17);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Customer";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(535, 452);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(199, 20);
            this.textBox10.TabIndex = 30;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(588, 495);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 26;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SalesModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 548);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesModuleUI";
            this.Text = "SalesModuleUI";
            this.Load += new System.EventHandler(this.SalesModuleUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox loyaltyPointTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.BindingSource addCustomerBindingSource;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource addCategoryBindingSource;
        private System.Windows.Forms.BindingSource addProductBindingSource;
    }
}