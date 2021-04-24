using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        private User obj = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddressTxtBx_TextChanged(object sender, EventArgs e)
        {
            MNoTxtBx.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] num = MNoTxtBx.Text.Split("-");

                //string test = "";
                //foreach(string st in num)
                //{
                //    test += st + " ";
                //}
                //MessageBox.Show(test);

                string finalStr = String.Join("", num);
                if(finalStr.Length == 10)
                {
                    UInt64 mNum = UInt64.Parse(finalStr);
                    obj.Name = NameTxtBx.Text;
                    obj.Address = AddressTxtBx.Text;
                    obj.MobileNumber = mNum;
                    string status = obj.FileStorage();
                    if (status.Equals("Pass"))
                        MessageBox.Show("The record is added");
                    else
                        MessageBox.Show("The record is not added");
                }
                else
                {
                    MessageBox.Show("Please renter the phone number");
                    MNoTxtBx.Text = "xxx-xxx-xxxx";
                    MNoTxtBx.Focus();
                }
            }
            catch(FormatException f)
            {
                MessageBox.Show($"Error Message : {f.Message}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Message : {ex.Message}");
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string finalStr = obj.FileDataAccess();
            if(!finalStr.Equals("Fail"))
            {
                FinalRecordsTxtBx.Text = finalStr;
            }
                
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTxtBx.Text = "";
            AddressTxtBx.Text = "";
            MNoTxtBx.Text = "xxx-xxx-xxxx";
            FinalRecordsTxtBx.Text = "";
        }
    }
}
