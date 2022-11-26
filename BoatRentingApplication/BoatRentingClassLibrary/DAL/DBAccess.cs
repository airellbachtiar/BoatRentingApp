using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class DBAccess : IStorageAccess
    {
        private MySqlConnection connection;

        public DBAccess(string connectionString)
        {
            //Make connection base on the path given
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetData(string sql)
        {
            try
            {
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                MySqlCommand command = connection.CreateCommand();

                //Add sql command to the chosen connection
                command.CommandText = sql;

                //Assign the command to a bridge between SQL and data table
                dataAdapter.SelectCommand = command;

                //Open connection
                connection.Open();

                //put the output of the command into data table
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //close current connection
                connection.Close();
            }
        }

        public void PostData(string sql)
        {
            try
            {
                //Create SQL command
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;

                //Open connection
                connection.Open();
                //Execute command to the chosen connection
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //Close connection
                connection.Close();
            }
        }
    }
}
