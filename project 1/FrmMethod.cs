using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class FrmMethod : Form
    {
        double a, b;

        double Balance;

        public FrmMethod()
        {
            InitializeComponent();
        }

        // Calculation Part
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtX.Text);
                b = Convert.ToDouble(txtY.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }


            MessageBox.Show("Sum of x and y is " + Add(a, b) +
               "" + "\nDifference of x and y is " + Subtract(a, b) +
               "" + "\nProduct of x and y is " + Multiply(a, b) +
               "" + "\nDividing  x by y is " + Divide(a, b) +
               "" + "\nRemainder of x and y is " + Rem(a, b)
              , "Result");
        }

        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Subtract(double a, double b)
        {
            return a - b;
        }
        private double Multiply(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }
        private double Rem(double a, double b)
        {
            return a % b;
        }

        // Your Account Part
        public void Deposit(double n)
        {
            CheckBalance();
            Balance += n;
        }
        public void Withdraw(double n)
        {
            CheckBalance();
            Balance -= n;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(txtAmount.Text);
                Withdraw(w);
                MessageBox.Show("Your current Balance is: " + Balance);
                txtAmount.Clear();
                CurrentBalance();
            }
            catch
            {
                if (txtBalance.Text == null)
                {
                    MessageBox.Show("Enter valid amount");
                }
                else
                {
                    MessageBox.Show("Please enter your current balance first, then the amount");
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(txtAmount.Text);
                Deposit(d);
                MessageBox.Show("Your current Balance is: " + Balance);
                txtAmount.Clear();
                CurrentBalance();
            }
            catch
            {
                if (txtBalance.Text == null)
                {
                    MessageBox.Show("Enter valid amount");
                }
                else
                {
                    MessageBox.Show("Please enter your current balance first, then the amount");
                }
                
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBalance();
                MessageBox.Show("Your current Balance is: " + Balance);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter your current balance");
            }
        }

        private double CheckBalance()
        {
            Balance = Convert.ToDouble(txtBalance.Text);
            return (Balance);
        }

        private string CurrentBalance()
        {
            txtBalance.Text = Convert.ToString(Balance);
            return (txtBalance.Text);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
