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
    public partial class SalesModuleUI : Form
    {
        public SalesModuleUI()
        {
            InitializeComponent();
        }
        Sales addSales = new Sales();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void SalesModuleUI_Load(object sender, EventArgs e)
        {
            customerComboBox.DataSource = addSales.CustomerCombo();
            loyaltyPointTextBox.Text = addSales.CustomerLoyaltyPoint(customerComboBox.Text);
        }
    }
}
