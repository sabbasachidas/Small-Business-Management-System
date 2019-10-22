﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System
{
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }
        AddCategory addCategory = new AddCategory();
        private void save_Click(object sender, EventArgs e)
        {
            if (addCategory.isNameExists(categoryCodeTextBox.Text, categoryNameTextBox.Text))
            {
                MessageBox.Show("Name already exists!!!");
                return;
            }
            if (addCategory.isCodeExists(categoryCodeTextBox.Text, categoryNameTextBox.Text))
            {
                MessageBox.Show("Code already exists!!!");
                return;
            }
            if (String.IsNullOrEmpty(categoryNameTextBox.Text) || String.IsNullOrEmpty(categoryCodeTextBox.Text))
            {
                MessageBox.Show("Name & Code are required!");
                return;
            }

            if (categoryCodeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be 4 digit!!!");
                return;
            }
            bool isAdded = addCategory.isAdded(categoryCodeTextBox.Text, categoryNameTextBox.Text);
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }

            showDataGridView.DataSource = addCategory.Display();
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
                categoryCodeTextBox.Text = row.Cells["categoryCodeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                categoryNameTextBox.Text = row.Cells["categoryNameDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = addCategory.Display();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryCodeTextBox.Text))
            {
                MessageBox.Show("Code is required!");
                return;
            }
            if (String.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Name is required!");
                return;
            }

            if (addCategory.Update(categoryCodeTextBox.Text, categoryNameTextBox.Text))
            {
                MessageBox.Show("Updated!");
                showDataGridView.DataSource = addCategory.Display();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (nameRadioButton.Checked)
            {
                showDataGridView.DataSource = addCategory.SearchName(categorySearchTextBox.Text);
            }
            else if(codeRadioButton.Checked)
            {
                showDataGridView.DataSource = addCategory.SearchCode(categorySearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Check radio Button");
            }
            //showDataGridView.DataSource = addCategory.Search(categorySearchTextBox.Text);
        }
    }
}
