//using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Elevator
{
    internal class Database
    {
        // Method to insert a record into the database
        public void insert_record(string actionperformed)
        {
           
            // Connection string for the database
            string url = "datasource=localhost;port=3306;username=root;password=#sudan12Tdk@";

            // SQL query to insert a record
            string sql = "INSERT INTO Elevator.actionlog(EntryDate, EntryTime, ActionPerformed) VALUES(@date,@time,@actionperformed)";

            // Database connection and command objects
            MySqlConnection conn = null;
            MySqlCommand command = null;
            try
            {
                // Attempt to connect to the database
                conn = new MySqlConnection(url);
                conn.Open();
                // Create a command with the SQL query and connection
                command = new MySqlCommand(sql, conn);
                // Get the current date and time
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToLongTimeString();
                // Set parameters for the SQL query
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@actionperformed", actionperformed);
                // Execute the SQL query and get the result
                int result = command.ExecuteNonQuery();
                //close connection 
                conn.Close();
              



            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Error : " + ex.Message);

            }

            //close connection
        }
        // Method to display records in a DataGridView
        public void display_records(DataGridView dataGridView1)
        {
            // Display All
            // Connection string for the database
            string url = "datasource=localhost;port=3306;username=root;password=#sudan12Tdk@";
            // SQL query to select all records
            string sql = "SELECT * FROM Elevator.actionlog";
            // Database connection, command, adapter, and table objects
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataAdapter adapter = null;
            DataTable table = null;
            try
            {
                // Connect to the database
                conn = new MySqlConnection(url);
                conn.Open();
                // Create a command with the SQL query and connection
                command = new MySqlCommand(sql, conn);
                // Create an adapter with the command
                adapter = new MySqlDataAdapter(command);
                // Create a DataTable and fill it with the result of the query
                table = new DataTable();
                adapter.Fill(table);
                // Set the DataGridView's DataSource to the DataTable
                dataGridView1.DataSource = table;

                // Set column widths and auto-size mode
                string aidColumnName = "Aid";
                string entrydateColumnName = "EntryDate";
                string entrytimeColumnName = "EntryTime";
                string actionPerformedColumnName = "ActionPerformed";
                

                dataGridView1.Columns[aidColumnName].Width = 30;
                dataGridView1.Columns[entrydateColumnName].Width = 100;
                dataGridView1.Columns[entrytimeColumnName].Width = 100;
                dataGridView1.Columns[actionPerformedColumnName].Width = 250;
                foreach(DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                // Close the database connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                // Close the database connection and dispose of the adapter
                if (conn != null)
                    conn.Close();

                if (adapter != null)
                    adapter.Dispose();
            }

        }
        // Method to delete all records from the table
        public void delete_record()
        {
            // Connection string for the database
            string url = "datasource=localhost;port=3306;username=root;password=#sudan12Tdk@";
            // SQL query to truncate (delete all records) from the table
            string del = "TRUNCATE TABLE Elevator.actionlog";

            // Database connection and command objects
            MySqlConnection conn = null;
            MySqlCommand command = null;

            try
            {
                // Connect to the database
                conn = new MySqlConnection(url);
                conn.Open();

                // Create a command with the SQL query and connection
                command = new MySqlCommand(del, conn);

                // Execute the SQL query to delete all records
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error: " + ex.Message);
            }
        }
       
       


    }
}
