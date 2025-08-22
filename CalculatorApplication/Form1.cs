using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
            cbOperator.SelectedItem = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            double result = 0;

            string operate = cbOperator.Text;

            if (operate == "+")
            {
                result = cal.GetSum(num1, num2);
            }
            else if (operate == "-") { 
                result = cal.GetDifference(num1, num2);
            } else
            {
                MessageBox.Show("Please SELECT a valid Operator!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                
            }



            lblDisplayTotal.Text = cal.GetSum(num1,num2).ToString();


        }
    }
}
