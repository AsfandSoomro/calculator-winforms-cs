using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_CS
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Global variables to store the current calculated answer and sign'
        private int? answer; // ? = Nullable Integer
        private string sign; 

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int[] nums = new int[2];
            string[] temp = new string[2];

            // Splits at the sign and stores the operands(strings) in temp array of strings
            if(sign != null) {
                temp = txtDisplay.Text.Split(sign.ToCharArray()[0]);
            }
            
            // Checks if either of the operand is empty, if it is then assigns "0" to it (string)
            if (temp[0] == "") temp[0] = "0";
            if (temp[1] == "") temp[1] = "0";

            // Converts the operands from string to integer
            nums[0] = Convert.ToInt32(temp[0]);
            nums[1] = Convert.ToInt32(temp[1]);
            
            // Performs Calculation as per sign
            if (sign == "+")
            {
                answer = nums[0] + nums[1];
            }
            else if (sign == "-")
            {
                answer = nums[0] - nums[1];
            }
            else if (sign == "/")
            {
                try { 
                    answer = nums[0] / nums[1]; 
                }
                catch (System.DivideByZeroException) {
                    MessageBox.Show("You cannot divide by zero", "Error");
                    clear();   
                }
            }
            else if (sign == "x")
            {
                answer = nums[0] * nums[1];
            }

            // Display the output on new on Display on newline
            if (sign != null && answer != null)
                txtDisplay.Text += Environment.NewLine + Convert.ToString(answer);

            // Resets the sign (for next calcultions)
            sign = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(sign == null) 
            {
                sign = "+";
                if (answer != null)
                    txtDisplay.Text = Convert.ToString(answer) + "+";
                else
                    txtDisplay.Text += "+";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (sign == null)
            {
                sign = "-";
                if (answer != null)
                    txtDisplay.Text = Convert.ToString(answer) + "-";
                else
                    txtDisplay.Text += "-";
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (sign == null)
            {
                sign = "/";
                if (answer != null)
                    txtDisplay.Text = Convert.ToString(answer) + "/";
                else
                    txtDisplay.Text += "/";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (sign == null)
            {
                sign = "x";
                if (answer != null)
                    txtDisplay.Text = Convert.ToString(answer) + "x";
                else
                    txtDisplay.Text += "x";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designDark();
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designLight();
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designRed();
        }

        // Resets calculator logic
        private void clear()
        {
            txtDisplay.Text = "";
            answer = null;
            sign = null;
        }

        private void designDark()
        {
            this.BackColor = Color.FromArgb(255, 32, 32, 32);

            txtDisplay.BackColor = Color.FromArgb(255, 32, 32, 32);
            txtDisplay.ForeColor = Color.White;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(255, 32, 32, 32);
                    c.ForeColor = Color.White;
                }
            }
            btnAdd.ForeColor = Color.Gold;
            btnMinus.ForeColor = Color.Gold;
            btnMultiply.ForeColor = Color.Gold;
            btnDivide.ForeColor = Color.Gold;
            btnClear.ForeColor = Color.Gold;
            btnRemove.ForeColor = Color.Gold;
            btnClear.ForeColor = Color.Gold;
            btnEqual.ForeColor = Color.Black;
            btnEqual.BackColor = Color.Gold;
        }
        private void designLight()
        {
            this.BackColor = Color.White;

            txtDisplay.BackColor = Color.White;
            txtDisplay.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }
            }
            btnAdd.ForeColor = Color.Black;
            btnMinus.ForeColor = Color.Black;
            btnMultiply.ForeColor = Color.Black;
            btnDivide.ForeColor = Color.Black;
            btnClear.ForeColor = Color.Black;
            btnRemove.ForeColor = Color.Black;
            btnClear.ForeColor = Color.Black;
            btnEqual.ForeColor = Color.Black;
            
        }
        
        private void designRed()
        {
            this.BackColor = Color.FromArgb (255,160,0,0);

            txtDisplay.BackColor = Color.FromArgb(255,139,0,0);
            txtDisplay.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(255, 139, 0, 0);
                    c.ForeColor = Color.Black;
                }
            }
            btnAdd.ForeColor = Color.FromArgb(255,139,0,0);
            btnMinus.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnMultiply.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnDivide.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnClear.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnRemove.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnClear.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnEqual.ForeColor = Color.FromArgb(255, 139, 0, 0);
            btnEqual.BackColor = Color.Black;
            btnRemove.BackColor = Color.Black;
            btnClear.BackColor = Color.Black;
            btnDivide.BackColor = Color.Black;
            btnMultiply.BackColor = Color.Black;
            btnMinus.BackColor = Color.Black;
            btnAdd.BackColor = Color.Black;
        }
    }
}
