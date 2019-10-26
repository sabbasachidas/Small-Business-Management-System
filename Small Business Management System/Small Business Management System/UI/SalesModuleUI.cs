using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Small_Business_Management_System.Manager;
using Small_Business_Management_System.Model;
using Small_Business_Management_System.BLL;

namespace Small_Business_Management_System
{
    public partial class SalesModuleUI : Form
    {
        public SalesModuleUI()
        {
            InitializeComponent();
        }
        Sales sales = new Sales();
        SalesManager _salesManager = new SalesManager();
        public List<Sales> _salesList = new List<Sales>();
        public void LoyaltyPoint()
        {
            
        }
       

        private void add_Click(object sender, EventArgs e)
        {
            sales.Customer = customerComboBox.Text;
            sales.Date = dateTimePicker.ToString();
            sales.Category = categoryComboBox.Text;
            sales.Product = productComboBox.Text;
            sales.Quantity = float.Parse(quantityTextBox.Text);
            sales.MRP = float.Parse(mrpTextBox.Text);
            sales.Total = (sales.Quantity * sales.MRP);
            _salesList.Add(sales);

            showDataGridView.DataSource = sales;
        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void SalesModuleUI_Load(object sender, EventArgs e)
        {
            customerComboBox.DataSource = _salesManager.CustomerCombo();
            loyaltyPointTextBox.Text = customerComboBox.SelectedValue.ToString();
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = _salesManager.categoryCombo();
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Code";
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource = null;
            productComboBox.DataSource = _salesManager.productCombo(categoryComboBox.Text);
            productComboBox.DisplayMember = "Name";
            productComboBox.ValueMember = "Code";
            
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableQuantityTextBox.Text = _salesManager.productQuantityCombo(productComboBox.Text);
        }

        
    }
}
