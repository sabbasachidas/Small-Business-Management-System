using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Small_Business_Management_System.Repository;

namespace Small_Business_Management_System
{
    public class AddProduct
    {
        public string Category { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ReorderLevel { set; get; }
        public string Description { set; get; }
        Connection connection = new Connection();
        public DataTable categoryCombo()
        {
            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT ID, Name FROM Category";
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
        public bool productAdd(string category, string code, string name, int reoderlevel, string description)
        {
            this.Category = category;
            this.Code = code;
            this.Name = name;
            this.ReorderLevel = reoderlevel;
            this.Description = description;
            bool isAdded = false;
            //connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            //command
            string commandstirng = @"INSERT INTO Product VALUES('" + category + "','" + code + "','" + name + "','" + reoderlevel + "','" + description + "','','','','','','','')";
            SqlCommand sqlcommand = new SqlCommand(commandstirng, sqlConnection);
            //open
            sqlConnection.Open();
            int isexecuted = sqlcommand.ExecuteNonQuery();

            if (isexecuted > 0)
            {
                isAdded = true;
            }

            //close
            sqlConnection.Close();

            return isAdded;
        }
        public bool isCodeExists(string code)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Product WHERE Code='" + code + "'";

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
        public bool isNameExists(string name)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"SELECT * FROM Product WHERE Name='" + name + "'";

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
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Product";
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

        public bool Update(string category, string code, string name, int reoderlevel, string description)
        {
            bool isUpdated = false;
            try
            {
                //Connection
                string connectionString = connection.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command
                string commandStirng = @"UPDATE Product SET Category = '" + category + "', Code = '" + code + "', Name = '" + name + "', ReorderLevel = '" + reoderlevel + "', ProductDescription = '" + description + "' WHERE " +
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
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Product WHERE Name='" + searchInput + "'";
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
        public DataTable SearchCategory(string searchInput)
        {



            //Connection
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Product WHERE Categoty='" + searchInput + "'";
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
            string connectionString = connection.connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command
            string commandStirng = @"SELECT * FROM Product WHERE Code='" + searchInput + "'";
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
