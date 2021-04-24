using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arshAssignment3_002
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void crtAcctBtn_Click(object sender, EventArgs e)
        {
            // getting name from text box
            string name = nameTxtBx.Text;

            // getting amount from text box 
            try
            {
                double amount = double.Parse(amountTxtBx.Text.ToString());

                // checking that the amount entered is greater than 0
                if(amount >= 0)
                {
                    balanceLblTxt.Text = amount.ToString("C");
                    amountTxtBx.Text = "";
                    crtAcctBtn.Visible = false;
                    MessageBox.Show($"The bank account is created for {name} with balance at ${amount}");
                }
                // if incorrect amount is entered display message and ask client to re-enter
                else
                {
                    MessageBox.Show("The amount entered is incorrect. Please re-enter the amount to be the starting balance for the new account.");
                    amountTxtBx.Text = "";
                    amountTxtBx.Focus();
                }
            }
            catch(FormatException f)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void depostBtn_Click(object sender, EventArgs e)
        {
            var obj = new BankAccount();
            string str = balanceLblTxt.Text.ToString();

            // to remove the $ character from beginning of balance
            obj.Balance = double.Parse(str[1..]);

            // to update the balance after the account is created and amount is added
            try
            {
                double amount = double.Parse(amountTxtBx.Text);

                // check if input amount entered is either 0 or positive
                if(amount >= 0)
                {
                    obj.Amount = amount;
                    balanceLblTxt.Text = obj.DepositAmount().ToString("C");
                    amountTxtBx.Text = "";
                    amountTxtBx.Focus();
                }
                // if amount less than 0 ask client to re-enter
                else
                {
                    MessageBox.Show("The amount entered is incorrect. Please re-enter the amount to be deposited.");
                    amountTxtBx.Text = "";
                    amountTxtBx.Focus();
                }

            }
            catch (FormatException f)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            var obj = new BankAccount();
            string str = balanceLblTxt.Text.ToString();

            // to remove the $ character from balance
            obj.Balance = double.Parse(str[1..]);

            // to update the balance after the account is created and amount is added
            try
            {
                double amount = double.Parse(amountTxtBx.Text);
                if(amount >= 0)
                {
                    obj.Amount = amount;
                    double wBal = obj.WithdrawAmount();
                    if (wBal != -1)
                    {
                        balanceLblTxt.Text = wBal.ToString("C");
                        amountTxtBx.Text = "";
                        amountTxtBx.Focus();
                    }
                    else
                    {
                        MessageBox.Show("The Amount to be withdrawn is greater than the Account Balance.");
                        amountTxtBx.Text = "";
                        amountTxtBx.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The amount entered is incorrect. Please re-enter the correct amount for withdrawal.");
                    amountTxtBx.Text = "";
                    amountTxtBx.Focus();
                }
            }
            catch (FormatException f)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {f.Message} and type : {f.GetType().Name}");
            }
            catch (Exception ex)
            {
                amountTxtBx.Text = "";
                amountTxtBx.Focus();
                MessageBox.Show($"Error Message : {ex.Message} and type : {ex.GetType().Name}");
            }
        }
    }
}
