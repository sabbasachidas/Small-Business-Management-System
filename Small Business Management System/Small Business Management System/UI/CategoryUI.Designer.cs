namespace Small_Business_Management_System
{
    partial class CategoryUI
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
            this.Code = new System.Windows.Forms.Label();
            this.categoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.show = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.categorySearchTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.codeRadioButton = new System.Windows.Forms.RadioButton();
            this.addCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(47, 57);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(32, 13);
            this.Code.TabIndex = 0;
            this.Code.Text = "Code";
            // 
            // categoryCodeTextBox
            // 
            this.categoryCodeTextBox.Location = new System.Drawing.Point(99, 54);
            this.categoryCodeTextBox.Name = "categoryCodeTextBox";
            this.categoryCodeTextBox.Size = new System.Drawing.Size(144, 20);
            this.categoryCodeTextBox.TabIndex = 1;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(99, 80);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.categoryNameTextBox.TabIndex = 3;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(47, 83);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(35, 13);
            this.l1.TabIndex = 2;
            this.l1.Text = "Name";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 118);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryCodeDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.addCategoryBindingSource1;
            this.showDataGridView.Location = new System.Drawing.Point(71, 222);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(352, 141);
            this.showDataGridView.TabIndex = 5;
            this.showDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellClick);
            // 
            // categoryCodeDataGridViewTextBoxColumn
            // 
            this.categoryCodeDataGridViewTextBoxColumn.DataPropertyName = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.HeaderText = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.Name = "categoryCodeDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // addCategoryBindingSource1
            // 
            this.addCategoryBindingSource1.DataSource = typeof(Small_Business_Management_System.AddCategory);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(99, 118);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 6;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(195, 118);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // categorySearchTextBox
            // 
            this.categorySearchTextBox.Location = new System.Drawing.Point(286, 79);
            this.categorySearchTextBox.Name = "categorySearchTextBox";
            this.categorySearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.categorySearchTextBox.TabIndex = 8;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(336, 118);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(288, 52);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(68, 17);
            this.nameRadioButton.TabIndex = 11;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "By Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // codeRadioButton
            // 
            this.codeRadioButton.AutoSize = true;
            this.codeRadioButton.Location = new System.Drawing.Point(379, 52);
            this.codeRadioButton.Name = "codeRadioButton";
            this.codeRadioButton.Size = new System.Drawing.Size(65, 17);
            this.codeRadioButton.TabIndex = 12;
            this.codeRadioButton.TabStop = true;
            this.codeRadioButton.Text = "By Code";
            this.codeRadioButton.UseVisualStyleBackColor = true;
            // 
            // addCategoryBindingSource
            // 
            this.addCategoryBindingSource.DataSource = typeof(Small_Business_Management_System.AddCategory);
            // 
            // categoryUIBindingSource
            // 
            this.categoryUIBindingSource.DataSource = typeof(Small_Business_Management_System.CategoryUI);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(140, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(86, 26);
            this.homeButton.TabIndex = 14;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // CategoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 402);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.codeRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.categorySearchTextBox);
            this.Controls.Add(this.update);
            this.Controls.Add(this.show);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.save);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.categoryCodeTextBox);
            this.Controls.Add(this.Code);
            this.Name = "CategoryUI";
            this.Text = "CategoryUI";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox categoryCodeTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.BindingSource addCategoryBindingSource;
        private System.Windows.Forms.BindingSource categoryUIBindingSource;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox categorySearchTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton codeRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addCategoryBindingSource1;
        private System.Windows.Forms.Button homeButton;
    }
}

