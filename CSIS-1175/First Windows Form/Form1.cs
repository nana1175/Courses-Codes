using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_P
{
    public partial class FirstAppForm : Form
    {
        public FirstAppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void btn1Display_Click(object sender, EventArgs e)
        {
            //string name = name1TextBox.Text;
            //labelDisplay.Text = "Welcome " + name;
            //name1TextBox.Text = "";
            //labelDisplay.Visible = true;

            int dep = 0;
            double hours = 0;
            var name = new string[2];

            // getting hours
            try
            {
                hours = double.Parse(hoursTextBox.Text);
            }
            catch(FormatException f)
            {
                hoursTextBox.Text = "0";
                hoursTextBox.Focus(); 
                MessageBox.Show($"Error message: {f.Message} and Type : {f.GetType().Name}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error message: {ex.Message} and Type : {ex.GetType().Name}");
            }

            // getting dependent hours
            try
            {
                dep = int.Parse(dependentTextBox.Text);
            }
            catch (FormatException f)
            {
                dependentTextBox.Text = "0";
                dependentTextBox.Focus();
                MessageBox.Show($"Error message: {f.Message} and Type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error message: {ex.Message} and Type : {ex.GetType().Name}");
            }

            // getting name
            name = name1TextBox.Text.Split(' ');
            if(name.Length < 2)
            {
                name1TextBox.Text = "Please enter full name";
                name1TextBox.Focus();
            }
            else
            {
                if(hours > 0)
                {
                    var emp = new Employee(name[0], name[1], dep, hours);
                    grossTextBox.Text = emp.DetermineGross().ToString("C");
                    deductTextBx.Text = emp.DetermineFedTax().ToString("C");
                    netPayTextBox.Text = emp.DetermineNet().ToString("C");
                    setVisibility(true);
                }
            }


        }

        private void btn1Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Enjoy my app");
            
        }

        private void dependentLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void setVisibility(bool vis)
        {
            grossLabel.Visible = vis;
            grossTextBox.Visible = vis;
            deductionLabel.Visible = vis;
            deductTextBx.Visible = vis;
            netPayLabel.Visible = vis;
            netPayTextBox.Visible = vis;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            setVisibility(false);
            name1TextBox.Text = "";
            hoursTextBox.Text = "";
            dependentTextBox.Text = "";
        }
    }
}
