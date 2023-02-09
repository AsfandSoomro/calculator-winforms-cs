using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

namespace Calculator_CS
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Expression expression = new Expression(txtDisplay.Text.Replace("%", "/100").Replace("x", "*"));
            try {
                Object result = expression.Eval();
                txtDisplay.Text = result.ToString();
            }
            catch (DivideByZeroException) {
                txtDisplay.Text = "Cannot divide by zero";
            }
            catch (Exception) {
                Console.WriteLine("Some exception occurred!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "x";
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

        // Resets calculator display text
        private void clear()
        {
            txtDisplay.Text = "";
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
            btnAdd.ForeColor = Color.Purple;
            btnMinus.ForeColor = Color.Purple;
            btnMultiply.ForeColor = Color.Purple;
            btnDivide.ForeColor = Color.Purple;
            btnClear.ForeColor = Color.Purple;
            btnRemove.ForeColor = Color.Purple;
            btnClear.ForeColor = Color.Purple;
            btnEqual.ForeColor = Color.White;
            btnEqual.BackColor = Color.Purple;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }
    }
}