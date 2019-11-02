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
using System.Globalization;

namespace Small_Business_Management_System
{
    public partial class SalesModuleUI : Form
    {
        public SalesModuleUI()
        {
            InitializeComponent();
        }
        Sales sales = new Sales();
        salesReport _salesReport = new salesReport();
        SalesManager _salesManager = new SalesManager();
        AddSales _addSales = new AddSales();
        
       

        private void add_Click(object sender, EventArgs e)
        {
            var datestring = dateTimePicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            sales.SalesCode = salesCodeTextBox.Text;
            sales.Customer = customerComboBox.Text;
            sales.Date = datestring;
            sales.Category = categoryComboBox.Text;
            sales.Product = productComboBox.Text;
            sales.Quantity = Convert.ToInt32(quantityTextBox.Text);
            sales.UnitPrice = _salesManager.productUnitPrice(productComboBox.Text);
            sales.MRP = Convert.ToDouble( mrpTextBox.Text );
            sales.Total = (sales.Quantity * sales.MRP);
            totalAmountTextBox.Text = sales.Total.ToString();

            _addSales.salesList.Add(sales);
            

            _salesReport.GrandTotal += sales.Total;
            grandTotaltextBox.Text = _salesReport.GrandTotal.ToString();

            _salesReport.LoyaltyPoint = _salesReport.GrandTotal / 1000;
            _salesReport.Discount = _salesReport.LoyaltyPoint / 10;
            _salesReport.LoyaltyPoint = _salesReport.LoyaltyPoint - (_salesReport.LoyaltyPoint / 10);
            _salesReport.DiscountAmount = (_salesReport.GrandTotal / 100) * _salesReport.Discount;
            _salesReport.PayableAmount = _salesReport.GrandTotal - _salesReport.DiscountAmount;
            discounrTextBox.Text = _salesReport.Discount.ToString();
            discountAmountTextBox.Text = _salesReport.DiscountAmount.ToString();
            payableAmountTextBox.Text = _salesReport.PayableAmount.ToString();

            

            if (String.IsNullOrEmpty(salesCodeTextBox.Text) || String.IsNullOrEmpty(quantityTextBox.Text) || String.IsNullOrEmpty(mrpTextBox.Text))
            {
                MessageBox.Show("Sales Code, Quantity & MRP are required!");
                return;
            }

            bool isAdded = _salesManager.isAdded(sales.SalesCode, sales.Customer, sales.Date, sales.Category, sales.Product, sales.Quantity, sales.MRP, sales.Total, sales.UnitPrice);
            if (isAdded)
            {
                quantityTextBox.Text = "";
                mrpTextBox.Text = "";
                totalAmountTextBox.Text = "";
                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _salesManager.DisplayAddedProduct(sales.SalesCode);
            }
            else
            {
                MessageBox.Show("Not saved!");
            }

            double quantity = Convert.ToDouble(_salesManager.productQuantity(productComboBox.Text));
            double reorderLevel = Convert.ToDouble(_salesManager.productReOrderLevel(productComboBox.Text));
            if(quantity <= reorderLevel)
            {
                MessageBox.Show("ReOrder level reached!!!");
            }


        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool isSubmited = _salesManager.isSubmited(sales.SalesCode, _salesReport.GrandTotal, _salesReport.Discount, _salesReport.DiscountAmount, _salesReport.PayableAmount);
            if(isSubmited)
            {
                MessageBox.Show("Sales Details Submited!!!");
            }
            else
            {
                MessageBox.Show("Try again!!!");
            }
            foreach(Sales sold in _addSales.salesList)
            {
                _salesManager.productQuantityUpdate(sold.Product, sold.Quantity);
            }

            showDataGridViewItems.DataSource = null;
            showDataGridViewItems.DataSource = _salesManager.DisplayAddedProduct(sales.SalesCode);
            showDataGridViewReport.DataSource = null;
            showDataGridViewReport.DataSource = _salesManager.DisplayAddedReport(sales.SalesCode);
            

        }

        private void search_Click(object sender, EventArgs e)
        {
            if(salesCodeRadioButton.Checked)
            {
                showDataGridViewItems.DataSource = null;
                showDataGridViewItems.DataSource = _salesManager.DisplayAddedProduct(searchTextBox.Text);
                showDataGridViewReport.DataSource = null;
                showDataGridViewReport.DataSource = _salesManager.DisplayAddedReport(searchTextBox.Text);
            }
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
            availableQuantityTextBox.Text = _salesManager.productQuantity(productComboBox.Text);
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showDataGridView.Rows[e.RowIndex];
                customerComboBox.Text = row.Cells["CustomerDataGridViewTextBoxColumn"].FormattedValue.ToString();
                salesCodeTextBox.Text = row.Cells["salesCodeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                categoryComboBox.Text = row.Cells["CategoryDataGridViewTextBoxColumn"].FormattedValue.ToString();
                productComboBox.Text = row.Cells["ProductDataGridViewTextBoxColumn"].FormattedValue.ToString();
                quantityTextBox.Text = row.Cells["QuantityDataGridViewTextBoxColumn"].FormattedValue.ToString();
                mrpTextBox.Text = row.Cells["MRPDataGridViewTextBoxColumn"].FormattedValue.ToString();
                totalAmountTextBox.Text = row.Cells["TotalDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }
        }

        
        private void update_Click(object sender, EventArgs e)
        {
            var datestring = dateTimePicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            sales.SalesCode = salesCodeTextBox.Text;
            sales.Customer = customerComboBox.Text;
            sales.Date = datestring;
            sales.Category = categoryComboBox.Text;
            sales.Product = productComboBox.Text;
            sales.Quantity = Convert.ToInt32(quantityTextBox.Text);
            sales.MRP = Convert.ToDouble(mrpTextBox.Text);
            sales.Total = (sales.Quantity * sales.MRP);
            totalAmountTextBox.Text = sales.Total.ToString();
            _salesReport.GrandTotal += sales.Total;
            grandTotaltextBox.Text = _salesReport.GrandTotal.ToString();

            _salesReport.LoyaltyPoint = _salesReport.GrandTotal / 1000;
            _salesReport.Discount = _salesReport.LoyaltyPoint / 10;
            _salesReport.LoyaltyPoint = _salesReport.LoyaltyPoint - (_salesReport.LoyaltyPoint / 10);
            _salesReport.DiscountAmount = (_salesReport.GrandTotal / 100) * _salesReport.Discount;
            _salesReport.PayableAmount = _salesReport.GrandTotal - _salesReport.DiscountAmount;
            discounrTextBox.Text = _salesReport.Discount.ToString();
            discountAmountTextBox.Text = _salesReport.DiscountAmount.ToString();
            payableAmountTextBox.Text = _salesReport.PayableAmount.ToString();

            if (String.IsNullOrEmpty(salesCodeTextBox.Text) || String.IsNullOrEmpty(quantityTextBox.Text) || String.IsNullOrEmpty(mrpTextBox.Text))
            {
                MessageBox.Show("Sales Code, Quantity & MRP are required!");
                return;
            }

            bool isUpdated = _salesManager.Update(sales.SalesCode, sales.Customer, sales.Date, sales.Category, sales.Product, sales.Quantity, sales.MRP, sales.Total);
            if (isUpdated)
            {
                quantityTextBox.Text = "";
                mrpTextBox.Text = "";
                totalAmountTextBox.Text = "";
                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _salesManager.DisplayAddedProduct(sales.SalesCode);
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }

        }
    }
}
