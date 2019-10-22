using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Small_Business_Management_System
{
    public class AddCustomer
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string LoyaltyPoint { set; get; }
        public bool CustomerAdd(string code, string name, string address, string email, string contact, string loyaltyPoint)
        {
            bool isAdded = false;
            this.Code = code;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Contact = contact;
            this.LoyaltyPoint = loyaltyPoint;
            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command
            string commandStirng = @"INSERT INTO Customer VALUES('" + code + "','" + name + "','" + address + "','" + email + "','" + contact + "','" + loyaltyPoint + "')";
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

            return isAdded;
         }
        public bool isCodeExists(string code)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Customer WHERE Code='" + code + "'";

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
        public bool isContactExists(string contact)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Customer WHERE Contact='" + contact + "'";

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
        public bool isEmailExists(string email)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Customer WHERE Email='" + email + "'";

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
            string commandStirng = @"SELECT * FROM Customer";
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

        public bool Update(string code, string name, string address, string email, string contact, string loyaltyPoint)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE Customer SET Code = '" + code + "', Name = '" + name + "', CustomerAddress = '" + address + "', Email = '" + email + "', Contact = '" + contact + "', LoyaltyPoint = '" + loyaltyPoint + "' WHERE " +
                    "Code= '" + code + "'";
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
            string commandStirng = @"SELECT * FROM Customer WHERE Name='" + searchInput + "'";
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
        public DataTable SearchContact(string searchInput)
        {



            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Customer WHERE Contact='" + searchInput + "'";
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
        public DataTable SearchEmail(string searchInput)
        {



            //Connection
            string connectionString = @"Server=DESKTOP-FTTBGUG\SQLEXPRESS; Database=SBMS; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Customer WHERE Email='" + searchInput + "'";
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
