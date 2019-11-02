using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System.UI
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var categoryUI = new CategoryUI();
            categoryUI.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            var salesUI = new SalesModuleUI();
            salesUI.Show();
        }
    }
}
