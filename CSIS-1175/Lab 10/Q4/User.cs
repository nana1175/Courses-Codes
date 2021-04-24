using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Q4
{
    class User
    {
        string name, address;
        UInt64 mobileNumber;
        string filePath = @"C:\Users\arshs\Documents\Github\CSIS-1175\Lab 10\Q4\bin\result.txt";

        public User () { }

        public User (string name, string address, UInt64 mobileNumber)
        {
            this.name = name;
            this.address = address;
            this.mobileNumber = mobileNumber;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public UInt64 MobileNumber { get; set; }


        public string FileStorage()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{Name}\t{Address}\t{MobileNumber}\t");
                    return "Pass";
                }
            }
            catch(IOException ioe)
            {
                MessageBox.Show($"Error Message : {ioe.Message}");
                return "Fail";
            }
           
        }
        public string FileDataAccess()
        {
            try
            {
                string line;
                string finalStr = "";
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            finalStr += line + "\r\n";
                        }
                    }
                }
                return finalStr;
            }
            catch (IOException ioe)
            {
                MessageBox.Show($"Error Message : {ioe.Message}");
                return "Fail";
            }


        }
    }
}
