using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Small_Business_Management_System.Repository
{
    public class CategoryRepository
    {
        public bool isAdded(string categoryCode, string categoryName)
        {
            bool isAdded = false;

            try
            {

                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command
                string commandStirng = @"INSERT INTO Category VALUES('" + categoryCode + "','" + categoryName + "')";
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

        public bool isCodeExists(string code, string name)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Category WHERE Code='" + code + "'";

                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);


                //Open
                sqlConnection.Open();
                //CHeck
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return exists;
        }
        public bool isNameExists(string code, string name)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command
                string commandStirng = @"SELECT * FROM Category WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandStirng, sqlConnection);
                //Open
                sqlConnection.Open();
                //CHeck
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return exists;
        }

        public DataTable Display()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Category";
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

        public bool Update(string code, string name)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE Category SET Code = '" + code + "', Name = '" + name +
                                       "' WHERE Code= '" + code + "'";
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

        public DataTable SearchName(string searchInput)
        {



            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Category WHERE Name='" + searchInput + "'";
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

        public DataTable SearchCode(string searchInput)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Category WHERE Code='" + searchInput + "'";
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
    }
}
