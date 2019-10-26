using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Small_Business_Management_System.Repository;
using Small_Business_Management_System.BLL;
using System.Data;
using System.Data.SqlClient;

namespace Small_Business_Management_System.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public bool isAdded(string categoryCode, string categoryName)
        {
            return _categoryRepository.isAdded(categoryCode, categoryName);
        }

        public bool isCodeExists(string code, string name)
        {
            return _categoryRepository.isCodeExists(code, name);
        }
        public bool isNameExists(string code, string name)
        {
            return _categoryRepository.isNameExists(code, name);
        }

        public DataTable Display()
        {
            
            return _categoryRepository.Display();
        }

        public bool Update(string code, string name)
        {
            return _categoryRepository.Update(code, name);
        }

        public DataTable SearchName(string searchInput)
        {
            return _categoryRepository.SearchName(searchInput);
        }

        public DataTable SearchCode(string searchInput)
        {
            return _categoryRepository.SearchCode(searchInput);
        }
    }
}
