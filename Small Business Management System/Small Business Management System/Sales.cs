using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Small_Business_Management_System
{
    public class Sales
    {
        public DataTable CustomerCombo()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT Code, Name FROM Customer";
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
        public string CustomerLoyaltyPoint(string customer)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT LoyaltyPoint FROM Customer WHERE Name = '"+customer+"'";
            SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);

            //Open
            sqlConnection.Open();

            //Display
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    loyaltyPoint = sqlDataReader[LoyaltyPoint];
            //}

            sqlConnection.Close();
            string loyaltyPoint = dataTable.ToString();
            return loyaltyPoint;

        }
    }
}
