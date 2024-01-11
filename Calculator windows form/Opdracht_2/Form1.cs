using System;
using System.Windows.Forms;

namespace Opdracht_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double getal1 = 0;
            string Operator = "";
            double getal2 = 0;
            double result = 0;

            if (double.TryParse(txtNum1.Text, out getal1) && double.TryParse(txtNum2.Text, out getal2))
            
           {
                Operator = txtOperator.Text;
                switch (Operator)
                {
                    case "+":
                        result = getal1 + getal2;
                        break;
                    case "-":
                        result = getal1 - getal2;
                        break;
                    case "*":
                        result = getal1 * getal2;
                        break;
                    case "/":
                        result = getal1 / getal2;

                        break;
                    default:
                        lblOutput.Text = "Invalid operator.";
                        return;
                }

                lblOutput.Text = result.ToString();
            }

            else
            {
                lblOutput.Text = "Invalid";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtOperator.Text = "";
            lblOutput.Text = "";
        }
    



        private void lblOutput_Click(object sender, EventArgs e)
                {

               }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblFam_Click(object sender, EventArgs e)
        {

        }

        private void lblNick_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
