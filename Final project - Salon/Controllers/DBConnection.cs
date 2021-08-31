using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Final_project___Salon
{
    /// <summary>
    /// Class For Data Base Connection Settings
    /// </summary>
    public class DBConnection
    {
        public static string DatabaseName = string.Empty;
        public static string UserName = string.Empty;
        public static string Password = string.Empty;

        private static DBConnection _instance = null; //_ => internal varaible 

        private static MySqlConnection connection = null;

        //Constructor
        // private DBConnection() { } //hides default public constructor

        protected static DBConnection Instance() //Not available to create an object, but reference will be sent
        {
            bool result = true;
            if (_instance == null)
            {
                _instance = new DBConnection();
                result = !string.IsNullOrEmpty(DatabaseName);
                if (result)
                {
                    string connString = string.Format("Server=localhost; database={0}; UID={1}; password={2}", DatabaseName, UserName, Password);
                    connection = new MySqlConnection(connString);
                }
            }
            return _instance;  //Reference to existing object. Not available to create more than one object of this class.
        }

        public bool Connect()
        {
            bool result = true;

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public void Close()
        {
            connection.Close();
        }

        protected bool ExecuteSimpleQuery(MySqlCommand command)
        {
            int numb = -1;
            return ExecuteSimpleQuery(command,ref numb);
        }

        //updating Query, we can know if request was completed successfully via changed rows, was saving to "number"-referns
        protected bool ExecuteSimpleQuery(MySqlCommand command, ref int numb)
        {
            bool result = true;

            lock (connection) //any other threads will wait for the block execution
            {
                if (Connect())
                {
                    command.Connection = connection;  //connect command to db with connection
                    try
                    {
                       numb = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return result;
        }

        protected int ExecuteScalarIntQuery(MySqlCommand command) //for queries that return one int (as count) 
        {
            int result = -1;

            lock (connection) //any other threads will wait for the block execution
            {
                if (Connect())
                {
                    command.Connection = connection;  //connect command to db with connection
                    try
                    {
                        result =  Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        result = -1;
                    }
                    finally
                    {
                        Close();
                    }
                }

                return result;
            }
        }

        protected DataSet GetMultipleQuery(MySqlCommand command) //returns dataset (הוסף רשומות)
        {
            DataSet dataset = new DataSet();
            lock (connection)
            {
                if (Connect())
                {
                    command.Connection = connection;  //physical conenction to db 
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();  //creating provider/adapter
                        adapter.SelectCommand = command;  //provides command to db
                        adapter.Fill(dataset); //fills adapter with dataset
                    }
                    catch (Exception e)
                    {
                        dataset = null;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return dataset;
        }
    }
}
