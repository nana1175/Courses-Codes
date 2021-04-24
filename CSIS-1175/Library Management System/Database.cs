using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    class Database
    {
        // declaring variables
        string dataStr;
        //string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\arshs\\Documents\\Github\\CSIS-1175\\Library Management System\\Credentials.mdf;Integrated Security=True";

        //declaring constructor
        public Database() { }

        // declaring parameterised constructor
        public Database(string dataStr)
        {
            this.dataStr = dataStr;
        }

        // implementing setter
        public string Datastr
        {
            set { dataStr = value; }
        }

        // creating database connection
        public string DatabaseConnection()
        {
            SqlCommand command;
            SqlDataReader sqlDataReader;
            string output = "";
            try
            {
                SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arshs\Documents\Github\CSIS-1175\Library Management System\Credentials.mdf;Integrated Security=True");
                con.Open();
               // MessageBox.Show("Connection Opened");
                command = new SqlCommand(dataStr, con);
                sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    output = output + sqlDataReader.GetValue(0) + " " + sqlDataReader.GetValue(1) + " | ";
                }
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }

            return output;
        }
        


        
        
        

    }
}
