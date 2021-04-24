using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); 
        }

    

        private void Logintbtn_Click(object sender, EventArgs e)
        {
            var objLogin = new Login();
            
            // getting values from text box
            try
            {
                objLogin.Username = userTextBox.Text;
                objLogin.Password = passTextBox.Text;
                string status = objLogin.PassValidation();
                if (status == "Pass")
                {
                    Admin ad = new();
                    MessageBox.Show("User Login Successful");
                    this.Hide();
                    ad.Show();
                }
                else
                    MessageBox.Show("Login Failed");
            }
            catch(FormatException f)
            {
                MessageBox.Show($"Error Message : {f.Message}");
                userTextBox.Text = "";
                userTextBox.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
        }

        private void showpassCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            // checking if checkbox is checked or not
            if (showpassCheckBx.CheckState == CheckState.Checked)
                passTextBox.UseSystemPasswordChar = false;
            else
                passTextBox.UseSystemPasswordChar = true;
        }
    }
}
