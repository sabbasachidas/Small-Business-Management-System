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
        public string productQuantityCombo(string product)
        {
            return _salesRepository.productQuantityCombo(product);
        }
    }
}
