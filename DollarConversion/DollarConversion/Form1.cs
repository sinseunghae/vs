using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarConversion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double usDollar;
            double output;

            if(txtUsDollar.Text == String.Empty)
            {
                MessageBox.Show("Textbox is empty, please input a numeric value.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsDollar.Focus();
            }
            else
            {
                if(Double.TryParse(txtUsDollar.Text, out usDollar) == true)
                {
                    if(usDollar < 1)
                    {
                        MessageBox.Show("Input value less than 1 is not allowed.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SendKeys.Send("{Home}+{End}");
                        txtUsDollar.Focus();
                    }
                    else
                    {               
                        if(rdbSingapore.Checked == true)
                        {
                            output = usDollar * 1.35;
                            //lblOutput.Text = output.ToString();
                            lblOutput.Text = String.Format("{0:#,0.00}", output);
                        }           
                        else if(rdbMalaysia.Checked == true)
                        {
                            output = usDollar * 4.15;
                            lblOutput.Text = String.Format("{0:#,0.00}", output);
                        }           
                        else if(rdbPhilippines.Checked == true)
                        {
                            output = usDollar * 50.79;
                            lblOutput.Text = String.Format("{0:#,0.00}", output);
                        }
                        else
                        {
                            MessageBox.Show("Please select a conversion.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUsDollar.Focus();
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Invalid input, please input a valid numeric value.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendKeys.Send("{Home}+{End}");
                    txtUsDollar.Focus();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsDollar.Clear();
            rdbSingapore.Checked = false;
            rdbMalaysia.Checked = false;
            rdbPhilippines.Checked = false;
            lblOutput.ResetText();
            txtUsDollar.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
