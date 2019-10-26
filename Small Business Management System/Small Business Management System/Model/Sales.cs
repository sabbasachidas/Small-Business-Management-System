using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.Model
{
    public class Sales
    {
        public string Customer { set; get; }
        public string Date { set; get; }
        public string Category { set; get; }
        public string Product { set; get; }
        public float Quantity { set; get; }
        public float MRP { set; get; }
        public float Total { set; get; }
        public float GrandTotal { set; get; }
        public float Discount { set; get; }
        public float DiscountAmount { set; get; }
        public float PayableAmount { set; get; }
    }
}
