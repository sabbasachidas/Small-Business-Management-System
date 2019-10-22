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
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }
        AddCustomer addCustomer = new AddCustomer();
        private void add_Click(object sender, EventArgs e)
        {
            if(addCustomer.isCodeExists(codeTextBox.Text))
            {
                MessageBox.Show("Code already exists!!!");
                return;
            }
            if (addCustomer.isContactExists(contactTextBox.Text))
            {
                MessageBox.Show("Contact already exists!!!");
                return;
            }
            if (addCustomer.isEmailExists(emailTextBox.Text))
            {
                MessageBox.Show("Email already exists!!!");
                return;
            }
            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be 4 digit!!!");
                return;
            }
            if (String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(contactTextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Name, Code, COntact and Email are required!");
                return;
            }
            bool isAdded = addCustomer.CustomerAdd(codeTextBox.Text, nameTextBox.Text, addressTextBox.Text, emailTextBox.Text,contactTextBox.Text, loyaltyPointTextBox.Text);
            if (isAdded)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Not saved!");
            }

            showDataGridView.DataSource = addCustomer.Display();
        }

        private void show_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = addCustomer.Display();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(codeTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(contactTextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Name, Code, COntact and Email are required!");
                return;
            }
            if (addCustomer.Update(codeTextBox.Text, nameTextBox.Text, addressTextBox.Text, emailTextBox.Text, contactTextBox.Text, loyaltyPointTextBox.Text))
            {
                MessageBox.Show("Updated!");
                showDataGridView.DataSource = addCustomer.Display();
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (radioButtonName.Checked)
            {
                showDataGridView.DataSource = addCustomer.SearchName(searchTextBox.Text);
            }
            else if (radioButtonContact.Checked)
            {
                showDataGridView.DataSource = addCustomer.SearchContact(searchTextBox.Text);
            }
            else if(radioButtonEmail.Checked)
            {
                showDataGridView.DataSource = addCustomer.SearchEmail(searchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Check radio Button");
            }
        }

        

        private void showDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
                codeTextBox.Text = row.Cells["codeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                nameTextBox.Text = row.Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                addressTextBox.Text = row.Cells["addressDataGridViewTextBoxColumn"].FormattedValue.ToString();
                emailTextBox.Text = row.Cells["emailDataGridViewTextBoxColumn"].FormattedValue.ToString();
                contactTextBox.Text = row.Cells["contactDataGridViewTextBoxColumn"].FormattedValue.ToString();
                loyaltyPointTextBox.Text = row.Cells["loyaltyPointDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }
        }
    }
}
