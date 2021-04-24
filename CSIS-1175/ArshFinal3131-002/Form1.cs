using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArshFinal3131_002
{
    public partial class Form1 : Form
    {
        // declaring object
        private Student obj = new Student();

        // declaring file paths
        private string mealPath = @"C:\Users\arshs\Documents\Finals\ArshFinal3131-002\bin\MealInfo.txt";
        private string dormPath = @"C:\Users\arshs\Documents\Finals\ArshFinal3131-002\bin\DormInfo.txt";
        private string stuPath = @"C:\Users\arshs\Documents\Finals\ArshFinal3131-002\bin\StudentInfo.txt";
        public Form1()
        {
            InitializeComponent();
            FinalTxtBx.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string line;

                // filling the meal list from the file
                using (StreamReader sr = new StreamReader(mealPath))
                {
                     while ((line = sr.ReadLine()) != null)
                        {
                            MealLst.Items.Add(line);
                        }
                }
                string newLine;

                // filling the dorm list from the file
                using (StreamReader sr = new StreamReader(dormPath))
                {
                    while ((newLine = sr.ReadLine()) != null)
                    {
                        DormLst.Items.Add(newLine);
                    }
                }

            }
            catch (IOException ioe)
            {
                MessageBox.Show($"Error Message : {ioe.Message}");
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                obj.StuId = UInt64.Parse(StuIdTxtBx.Text);
                
                // checking all the inputs are entered
                if(!NameTxtBx.Text.Equals("")  && !EmailTxtBx.Equals(" ")  && (DormLst.SelectedItem != null) && (MealLst.SelectedItem != null) && (GradeRdBtn.Checked || UndergradRdBtn.Checked))
                {
                    obj.StuName = NameTxtBx.Text;
                    obj.StuEmail = EmailTxtBx.Text;
                    obj.DormInfo = DormLst.SelectedItem.ToString();
                    obj.MealInfo = MealLst.SelectedItem.ToString();

                    // checking the radiobutton's status
                    if (GradeRdBtn.Checked)
                        obj.Status = "Grade";
                    else
                        obj.Status = "Undergrad";

                    // checking the checkbox status
                    if(BreakfastChkBx.Checked)
                    {
                        // calculating cost
                        string finalStr = obj.CalculateCost("Yes");
                        // retrieving total cost
                        string costStr = finalStr.Split(" ").Last();
                        // sending data for file creation
                        obj.FileDataSaver(costStr, stuPath);
                        FinalTxtBx.Text = finalStr;
                        FinalTxtBx.Visible = true;
                        MessageBox.Show("Student Acccount is created successfully and info is saved");
                       
                    }
                    else
                    {
                        string finalStr = obj.CalculateCost("No");
                        string costStr = finalStr.Split(" ").Last();
                        obj.FileDataSaver(costStr, stuPath);
                        FinalTxtBx.Text = finalStr;
                        FinalTxtBx.Visible = true;
                        MessageBox.Show("Student Acccount is created successfully and info is saved");
                        
                    }
                } 
                else
                {
                    MessageBox.Show("Please select all the required inputs");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Input string was not in a correct format");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // closing the form
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // resetting the form
            StuIdTxtBx.Text = "";
            NameTxtBx.Text = "";
            EmailTxtBx.Text = "";
            GradeRdBtn.Checked = false;
            UndergradRdBtn.Checked = false;
            BreakfastChkBx.Checked = false;
            DormLst.SelectedItem = null;
            MealLst.SelectedItem = null;
            FinalTxtBx.Visible = false;
        }

    }
}
