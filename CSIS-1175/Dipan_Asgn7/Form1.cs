using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipan_Asgn7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            quizWegTxtBx.Text = (0.2).ToString();
            assgnWeightTxtBx.Text = (0.15).ToString();
            midWegTxtBx.Text = (0.3).ToString();
            finalWegTxtBx.Text = (0.35).ToString();
        }






        private static string LetterGrade(float marks)
        {
            if (marks >= 95)
                return "A+";
            else if (marks < 95 && marks >= 90)
                return "A";
            else if (marks < 90 && marks >= 85)
                return "A-";
            else if (marks < 85 && marks >= 80)
                return "B+";
            else if (marks < 80 && marks >= 75)
                return "B";
            else if (marks < 75 && marks >= 70)
                return "B-";
            else if (marks < 70 && marks >= 65)
                return "C+";
            else if (marks < 65 && marks >= 60)
                return "C";
            else if (marks < 60 && marks >= 55)
                return "C-";
            else if (marks < 60 && marks >= 55)
                return "P";
            else
                return "F";
        }

        private static Boolean WeightCheck(float weight)
        {
            if (weight >= 0 && weight < 1)
                return true;
            else
                return false;
        }

        private static Boolean GradeCheck(float grade)
        {
            if (grade >= 0 && grade <= 100)
                return true;
            else
                return false;
        }

        private void quizWegTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(quizWegTxtBx.Text);
                if(!WeightCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 1 for Quiz Weight");
                    quizWegTxtBx.Text = "0";
                    quizWegTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                quizWegTxtBx.Text = "0";
                quizWegTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                quizWegTxtBx.Text = "0";
                quizWegTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void assgWegTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(assgnWeightTxtBx.Text);
                float quizWeg = float.Parse(quizWegTxtBx.Text);
                if(!WeightCheck(val + quizWeg))
                {
                    MessageBox.Show($"Please enter value from 0 to {1 - quizWeg} for Assignment Weight");
                    assgnWeightTxtBx.Text = "0";
                    assgnWeightTxtBx.Focus();
                }
                else if (!WeightCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 1 for Assignment Weight");
                    assgnWeightTxtBx.Text = "0";
                    assgnWeightTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                assgnWeightTxtBx.Text = "0";
                assgnWeightTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                assgnWeightTxtBx.Text = "0";
                assgnWeightTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void midWegTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(midWegTxtBx.Text);
                float quizWeg = float.Parse(quizWegTxtBx.Text);
                float assWeg = float.Parse(assgnWeightTxtBx.Text);
                if (!WeightCheck(val + quizWeg + assWeg))
                {
                    MessageBox.Show($"Please enter value from 0 to {1 - quizWeg - assWeg} for Assignment Weight");
                    midWegTxtBx.Text = "0";
                    midWegTxtBx.Focus();
                }
                else if (!WeightCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 1 for Midterm Weight");
                    midWegTxtBx.Text = "0";
                    midWegTxtBx.Focus();
                }
                else
                {
                    finalWegTxtBx.Text = Math.Round((1 - (float.Parse(quizWegTxtBx.Text) + float.Parse(assgnWeightTxtBx.Text) + float.Parse(midWegTxtBx.Text))), 2).ToString();
                }
            }
            catch (FormatException f)
            {
                midWegTxtBx.Text = "0";
                midWegTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                midWegTxtBx.Text = "0";
                midWegTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

       
        private void calWegAvgBtn_Click(object sender, EventArgs e)
        {
            // calculating final weight
            float finalWeight = float.Parse(quizGdTxtBx.Text) * float.Parse(quizWegTxtBx.Text) + float.Parse(assgGdTxtBx.Text) * float.Parse(assgnWeightTxtBx.Text) + float.Parse(midGdTxtBx.Text) * float.Parse(midWegTxtBx.Text) + float.Parse(finalGdTxtBx.Text) * float.Parse(finalWegTxtBx.Text);
            string grade = LetterGrade(finalWeight);
            finalGdWegTxtBx.Text = finalWeight.ToString();
            finalGradeTxtBx.Text = grade;

        }

        private void quizGdTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(quizGdTxtBx.Text);
                if (!GradeCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 100 for Quiz Grade");
                    quizGdTxtBx.Text = "0";
                    quizGdTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                quizGdTxtBx.Text = "0";
                quizGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                quizGdTxtBx.Text = "0";
                quizGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void assgGdTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(assgGdTxtBx.Text);
                if (!GradeCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 100 for Assignment Grade");
                    assgGdTxtBx.Text = "0";
                    assgGdTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                assgGdTxtBx.Text = "0";
                assgGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                assgGdTxtBx.Text = "0";
                assgGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void midGdTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(midGdTxtBx.Text);
                if (!GradeCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 100 for Midterm Grade");
                    midGdTxtBx.Text = "0";
                    midGdTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                midGdTxtBx.Text = "0";
                midGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                midGdTxtBx.Text = "0";
                midGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void finalGdTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float val = float.Parse(finalGdTxtBx.Text);
                if (!GradeCheck(val))
                {
                    MessageBox.Show("Please enter value from 0 to 100 for Final Grade");
                    finalGdTxtBx.Text = "0";
                    finalGdTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                finalGdTxtBx.Text = "0";
                finalGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                finalGdTxtBx.Text = "0";
                finalGdTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void finalWegTxtBx_TextChanged(object sender, EventArgs e)
        {
            finalWegTxtBx.Enabled = false;
        }
    }
}
