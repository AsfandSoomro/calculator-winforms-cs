using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                Object result = expression.Eval();
                txtDisplay.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Cannot divide by zero";
            }
            catch (Exception)
            {
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
            designChange(Color.FromArgb(255, 32, 32, 32),Color.White,Color.Gold);
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designChange(Color.White,Color.Black,Color.Purple);
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designRed();
        }

        // Resets calculator display text
        private void clear()
        {
            txtDisplay.Text = "";
        }

        private void designChange(Color backColor, Color foreColor, Color accentColor)
        {
            this.BackColor = backColor;

            txtDisplay.BackColor = backColor;
            txtDisplay.ForeColor = foreColor;

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = backColor;
                btn.ForeColor = foreColor;

                if (!Regex.IsMatch(btn.Text, @"[0-9.%]"))
                {
                    btn.ForeColor = accentColor;
                }
            }
            btnEqual.ForeColor = backColor;
            btnEqual.BackColor = accentColor;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form customize = new Customize();
            if (customize.ShowDialog() == DialogResult.OK)
            {
                designChange(Customize.backColor, Customize.foreColor, Customize.accentColor);
            }
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form customize = new Customize();
            if (customize.ShowDialog() == DialogResult.OK)
            {
                designChange(Customize.backColor, Customize.foreColor, Customize.accentColor);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back) {
                btnRemove.PerformClick();
            }
            else if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
                btnEqual.PerformClick();
            }
            else if(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) {
                txtDisplay.Text += (char)e.KeyData;
            }
            else if(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) {
                txtDisplay.Text += (int)(e.KeyCode - Keys.NumPad0);
            }
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls fm = new Controls();
            fm.Show();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designRed();
        }

        private void designRed()
        {
            this.BackColor = Color.FromArgb(255, 160, 0, 0);

            txtDisplay.BackColor = Color.FromArgb(255, 139, 0, 0);
            txtDisplay.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(255, 139, 0, 0);
                    c.ForeColor = Color.Black;
                }
            }
            btnAdd.ForeColor = Color.FromArgb(255, 139, 0, 0);
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