using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Login
    {
        // declaring variables
        string username, password, dataStr;

        // declaring default constructor
        public Login() { }

        // parameterised constructor
        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // declaring getter and setters
        public string Username { get; set; }
        public string Password { get; set; }

        // validation of password
        public string PassValidation()
        {
            string query = "select ID,PASSWORD from LOGIN";
            var obj = new Database(query);
            string result1 = obj.DatabaseConnection();
            var result = result1.Split(' ');
            if ((result[0] == Username) && result[1] == Password)
                return "Pass";
            else
                return "Fail";
        }


    }
}
