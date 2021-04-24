using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BagsLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(int.TryParse(QuantityTxtBx.Text, out int val) && val >= 0 && val <= 10)
                {
                    MessageBox.Show($"The item selected is {BagsLst.SelectedItem.ToString()} & the quantity is {val}");
                }
                else
                {
                    MessageBox.Show("Please enter the quantity in between 0 and 10");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"The Error Message is {ex.Message}");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            QuantityTxtBx.Text = "";
            BagsLst.ClearSelected();
        }
    }
}
