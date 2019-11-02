using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.Model
{
    public class Sales
    {
        public string SalesCode { set; get; }
        public string Customer { set; get; }
        public string Date { set; get; }
        public string Category { set; get; }
        public string Product { set; get; }
        public double UnitPrice { set; get; }
        public int Quantity { set; get; }
        public double MRP { set; get; }
        public double Total { set; get; }
        
    }
    public class salesReport
    {
        public double GrandTotal { set; get; }
        public double LoyaltyPoint { set; get; }
        public double Discount { set; get; }
        public double DiscountAmount { set; get; }
        public double PayableAmount { set; get; }
        
    }
}
