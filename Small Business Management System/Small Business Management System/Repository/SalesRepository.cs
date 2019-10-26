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
        public DataTable CustomerCombo()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
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
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
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
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
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
        public string productQuantityCombo(string product)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
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
    }
}
