using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Small_Business_Management_System.Repository
{
    public class SalesRepository
    {
        Connection connection = new Connection();
        public DataTable CustomerCombo()
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Code, Name, LoyaltyPoint FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }
        public DataTable categoryCombo()
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Code, Name FROM Category";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }
        public DataTable productCombo(string category)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Code, Name, Quantity FROM Product WHERE Category='" + category + "'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }
        public string quantity;
        public string productQuantity(string product)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Quantity FROM Product WHERE Name='" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                quantity = dataTable.Rows[0]["Quantity"].ToString();
            }
            return quantity;

        }
        public string reorderLevel;
        public string productReOrderLevel(string product)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT ReorderLevel FROM Product WHERE Name='" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                reorderLevel = dataTable.Rows[0]["ReorderLevel"].ToString();
            }
            return reorderLevel;

        }
        public bool isAdded(string salesCode, string customer, string date, string category, string product, int quantity, double mrp, double total, double unitPrice)
        {
            bool isAdded = false;

            try
            {

                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command
                string commandStirng = @"INSERT INTO SalesProducts VALUES('" + salesCode + "','" + customer + "','" + date + "','" + category + "','" + product + "','" + quantity + "','" + mrp + "','" + total + "', '"+unitPrice+"')";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);
                //Open
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //throw;
            }

            return isAdded;
        }
        public DataTable DisplayAddedProduct( string salesCode)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM SalesProducts WHERE SalesCode='"+salesCode+"' ";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
        public bool Update(string salesCode, string customer, string date, string category, string product, int quantity, double mrp, double total)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE SalesProducts SET Customer = '" + customer + "', Date = '" + date + "',Category = '" + category + "', Product = '" + product + "', Quantity = '" + quantity + "', MRP = '" + mrp + "', Total = '" + total + "' WHERE SalesCode= '" + salesCode + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isUpdated = true;
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)

            {
                //MessageBox.Show(exception.Message);
            }

            return isUpdated;
        }
        public bool isSubmited(string salesCode, double grandTotal, double discount, double discountAmount, double payableAmaount)
        {
            bool isAdded = false;

            try
            {

                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command
                string commandStirng = @"INSERT INTO Sales VALUES('" + salesCode + "','" + grandTotal + "','" + discount + "','" + discountAmount + "','" + payableAmaount + "')";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);
                //Open
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                //Close
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //throw;
            }

            return isAdded;
        }
        public bool productQuantityUpdate(string product, int quantitySold)
        {
            bool isUpdated = false;
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Quantity FROM Product WHERE Name='" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                quantity = dataTable.Rows[0]["Quantity"].ToString();
            }

            int newQuantity = Convert.ToInt32(quantity) - quantitySold;

            //Command
            string commandStirng2 = @"UPDATE Product SET Quantity = '" + newQuantity + "' WHERE Name= '"+product+"'";
            SqlCommand sqlCommand2 = new SqlCommand(commandStirng2, sqlConnection);

            
            //Insert
            int isExecuted = sqlCommand2.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                isUpdated = true;
            }
            else
            {
                isUpdated = false;
            }

            sqlConnection.Close();
            return isUpdated;
        }

        public DataTable DisplayAddedReport(string salesCode)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Sales WHERE SalesCode='" + salesCode + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public string unitPrice;
        public double productUnitPrice(string product)
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT UnitPrice FROM Product WHERE Name='" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            if (dataTable.Rows.Count > 0)
            {
                unitPrice = dataTable.Rows[0]["UnitPrice"].ToString();
            }
            return Convert.ToDouble(unitPrice);

        }

    }
}
