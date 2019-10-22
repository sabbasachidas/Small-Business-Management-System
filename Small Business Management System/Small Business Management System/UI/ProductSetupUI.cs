using System;
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
    public partial class ProductSetupUI : Form
    {
        public ProductSetupUI()
        {
            InitializeComponent();
        }
        //private void ProductSetupUI_Load(object sender, EventArgs e)
        //{
            
        //}
        AddProduct addProduct = new AddProduct();
        private void save_Click(object sender, EventArgs e)
        {
            if (addProduct.isNameExists(nameTextBox.Text))
            {
                MessageBox.Show("Name already exists!!!");
                return;
            }
            if (addProduct.isCodeExists(categoryComboBox.Text))
            {
                MessageBox.Show("Code already exists!!!");
                return;
            }
            if (String.IsNullOrEmpty(categoryComboBox.Text) || String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(reorderTextBox.Text))
            {
                MessageBox.Show("Name , Code, Category and Description are required!");
                return;
            }

            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be 4 digit!!!");
                return;
            }
            bool isAdded = addProduct.productAdd(categoryComboBox.Text, codeTextBox.Text, nameTextBox.Text,Convert.ToInt32(reorderTextBox.Text), descriptionTextBox.Text);
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }

            showDataGridView.DataSource = addProduct.Display();
        }

        private void show_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = addProduct.Display();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryComboBox.Text) || String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(reorderTextBox.Text))
            {
                MessageBox.Show("Name, Code, COntact and Email are required!");
                return;
            }
            if (addProduct.Update(categoryComboBox.Text, codeTextBox.Text, nameTextBox.Text, Convert.ToInt32(reorderTextBox.Text), descriptionTextBox.Text))
            {
                MessageBox.Show("Updated!");
                showDataGridView.DataSource = addProduct.Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (radioButtonCategory.Checked)
            {
                showDataGridView.DataSource = addProduct.SearchCategory(searchTextBox.Text);
            }
            else if (radioButtonName.Checked)
            {
                showDataGridView.DataSource = addProduct.SearchName(searchTextBox.Text);
            }
            else if (radioButtonCode.Checked)
            {
                showDataGridView.DataSource = addProduct.SearchCode(searchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Check radio Button");
            }
        }

        private void ProductSetupUI_Load_1(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = addProduct.categoryCombo();
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
                codeTextBox.Text = row.Cells["codeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                nameTextBox.Text = row.Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                reorderTextBox.Text = row.Cells["reorderLevelDataGridViewTextBoxColumn"].FormattedValue.ToString();
                descriptionTextBox.Text = row.Cells["descriptionDataGridViewTextBoxColumn"].FormattedValue.ToString();
                
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
