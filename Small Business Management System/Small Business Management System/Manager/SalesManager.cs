using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Small_Business_Management_System.Repository;
using System.Data;

namespace Small_Business_Management_System.Manager
{
    public class SalesManager
    {
        SalesRepository _salesRepository = new SalesRepository();
        public DataTable CustomerCombo()
        {
            return _salesRepository.CustomerCombo();
        }
        public DataTable categoryCombo()
        {
            return _salesRepository.categoryCombo();
        }
        public DataTable productCombo(string category)
        {
            return _salesRepository.productCombo(category);
        }
        public string productQuantity(string product)
        {
            return _salesRepository.productQuantity(product);
        }
        public bool isAdded(string salesCode, string customer, string date, string category, string product, int quantity, double mrp, double total, double unitPrice)
        {
            return _salesRepository.isAdded(salesCode, customer, date, category, product, quantity, mrp, total,unitPrice);
        }
        public DataTable DisplayAddedProduct(string salesCode)
        {
            return _salesRepository.DisplayAddedProduct(salesCode);
        }
        public bool Update(string salesCode, string customer, string date, string category, string product, int quantity, double mrp, double total)
        {
            return _salesRepository.Update(salesCode, customer, date, category, product, quantity, mrp, total);
        }
        public bool isSubmited(string salesCode, double grandTotal, double discount, double discountAmount, double payableAmaount)
        {
            return _salesRepository.isSubmited(salesCode, grandTotal, discount, discountAmount, payableAmaount);
        }
        public bool productQuantityUpdate(string product, int quantitySold)
        {
            return _salesRepository.productQuantityUpdate(product, quantitySold);
        }
        public DataTable DisplayAddedReport(string salesCode)
        {
            return _salesRepository.DisplayAddedReport(salesCode);
        }
        public string productReOrderLevel(string product)
        {
            return _salesRepository.productReOrderLevel(product);
        }
        public double productUnitPrice(string product)
        {
            return _salesRepository.productUnitPrice(product);
        }
    }
}
