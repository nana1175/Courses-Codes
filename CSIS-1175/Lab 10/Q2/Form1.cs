using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardwoodLst.Visible = false;
        }

        private double DimensionExtract(string str)
        {
            string[] valInitial = str.Split(" ");
            double valFeet = double.Parse(valInitial[0]);
            double valInch = double.Parse(valInitial[2]);
            double valYard = valFeet * 0.3 + valInch * 0.0278;
            return valYard;
        }

        private void LengthTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = LengthTxtBx.Text;
                double lenVal = DimensionExtract(str);
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

        private void WidthTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double widVal = DimensionExtract(WidthTxtBx.Text);
            }
            catch (FormatException f)
            {
                MessageBox.Show($"Error Message : {f.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message : {ex.Message}");
            }
        }

        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!HardwoodRdBtn.Checked && !CarpetRdBtn.Checked && !LaminateRdBtn.Checked)
                MessageBox.Show("Please select a choice");
            else
            {
                if(HardwoodRdBtn.Checked)
                {
                    HardwoodLst.Visible = true;
                }
            }
        }

        private void HardwoodChooseBtn_Click(object sender, EventArgs e)
        {
            string item = HardwoodLst.SelectedItem.ToString();
            if(item.Equals(""))
            {
                MessageBox.Show("Please select an item");
            }
                
        }

        private void PriceCalcBtn_Click(object sender, EventArgs e)
        {
            double lenYard = DimensionExtract(LengthTxtBx.Text);
            double widYard = DimensionExtract(WidthTxtBx.Text);

            if(HardwoodRdBtn.Checked)
            {
                string[] str = HardwoodLst.SelectedItem.ToString().Split(" ");
                double price = double.Parse(str[1].Substring(1));
                double totalCost = lenYard * widYard * price;
                FinalTxtBx.Text = totalCost.ToString("C");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LengthTxtBx.Text = "";
            WidthTxtBx.Text = "";
            HardwoodLst.ClearSelected();
            HardwoodLst.Visible = false;
            HardwoodRdBtn.Checked = false;
            LaminateRdBtn.Checked = false;
            CarpetRdBtn.Checked = false;
        }
    }
}
