using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_WF_Vasilchenko
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operationDone = "";
        bool isOperationDone = false;
        bool isResultPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numBtn_click(object sender, EventArgs e)
        {

            if (isResultPressed == true)
            {
                tbInput.Clear();
                isResultPressed = false;
            }

            if (tbInput.Text == "0" || isOperationDone == true)
                tbInput.Clear();

            isOperationDone = false;
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!tbInput.Text.Contains("."))
                    tbInput.Text = tbInput.Text + btn.Text;
            }
            else
                tbInput.Text += btn.Text;
        }

        private void operBtn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (result != 0)
            {
                btnResult.PerformClick();
                operationDone = btn.Text;
                isOperationDone = true;
            }
            else
            {
                operationDone = btn.Text;
                result = Double.Parse(tbInput.Text);
                isOperationDone = true;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            tbInput.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Text = "0";
            result = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operationDone)
            {
                case "+":
                    tbInput.Text = (result + Double.Parse(tbInput.Text)).ToString();
                    break;
                case "-":
                    tbInput.Text = (result - Double.Parse(tbInput.Text)).ToString();
                    break;
                case "x":
                    tbInput.Text = (result * Double.Parse(tbInput.Text)).ToString();
                    break;
                case "/":
                    if (tbInput.Text == "0")
                        tbInput.Text = "Can not devide by zero";
                    else
                        tbInput.Text = (result / Double.Parse(tbInput.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(tbInput.Text);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            int idx = tbInput.Text.Length;
            idx--;
            tbInput.Text = tbInput.Text.Remove(idx);
            if (tbInput.Text == "")
                tbInput.Text = "0";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = result * -1;
            tbInput.Text = result.ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result /= 100;
            tbInput.Text = result.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = Math.Sqrt(result);
            tbInput.Text = result.ToString();
        }

        private void btnPow2_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = Math.Pow(result, 2);
            tbInput.Text = result.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = Math.Log10(result);
            tbInput.Text = result.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = Math.Log(result);
            tbInput.Text = result.ToString();
        }

        private void btnUnder_Click(object sender, EventArgs e)
        {
            result = Double.Parse(tbInput.Text);
            result = 1 / result; ;
            tbInput.Text = result.ToString();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Messages.CloseConfirmationDialog();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
