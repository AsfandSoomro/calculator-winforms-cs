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

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            StringToFormula stf = new StringToFormula();
            double result = stf.Eval(txtDisplay.Text);
            txtDisplay.Text = result.ToString();
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
            txtDisplay.Text += "*";
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

        public class StringToFormula
        {
            private string[] _operators = { "-", "+", "/", "*", "^" };
            private Func<double, double, double>[] _operations = {
        (a1, a2) => a1 - a2,
        (a1, a2) => a1 + a2,
        (a1, a2) => a1 / a2,
        (a1, a2) => a1 * a2,
        (a1, a2) => Math.Pow(a1, a2)
    };

            public double Eval(string expression)
            {
                List<string> tokens = getTokens(expression);
                Stack<double> operandStack = new Stack<double>();
                Stack<string> operatorStack = new Stack<string>();
                int tokenIndex = 0;

                while (tokenIndex < tokens.Count)
                {
                    string token = tokens[tokenIndex];
                    if (token == "(")
                    {
                        string subExpr = getSubExpression(tokens, ref tokenIndex);
                        operandStack.Push(Eval(subExpr));
                        continue;
                    }
                    if (token == ")")
                    {
                        throw new ArgumentException("Mis-matched parentheses in expression");
                    }
                    //--// 
                    if (Array.IndexOf(_operators, token) >= 0)
                    {
                        while (operatorStack.Count > 0 && Array.IndexOf(_operators, token) < Array.IndexOf(_operators, operatorStack.Peek()))
                        {
                            string op = operatorStack.Pop();
                            double arg2 = operandStack.Pop();
                            double arg1 = operandStack.Pop();
                            operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
                        }
                        operatorStack.Push(token);
                    }
                    else
                    {
                        operandStack.Push(double.Parse(token));
                    }
                    tokenIndex += 1;
                }

                while (operatorStack.Count > 0)
                {
                    string op = operatorStack.Pop();
                    double arg2 = operandStack.Pop();
                    double arg1 = operandStack.Pop();
                    operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
                }
                return operandStack.Pop();
            }

            private string getSubExpression(List<string> tokens, ref int index)
            {
                StringBuilder subExpr = new StringBuilder();
                int parenlevels = 1;
                index += 1;
                while (index < tokens.Count && parenlevels > 0)
                {
                    string token = tokens[index];
                    if (tokens[index] == "(")
                    {
                        parenlevels += 1;
                    }

                    if (tokens[index] == ")")
                    {
                        parenlevels -= 1;
                    }

                    if (parenlevels > 0)
                    {
                        subExpr.Append(token);
                    }

                    index += 1;
                }

                if ((parenlevels > 0))
                {
                    throw new ArgumentException("Mis-matched parentheses in expression");
                }
                return subExpr.ToString();
            }

            private List<string> getTokens(string expression)
            {
                string operators = "()^*/+-";
                List<string> tokens = new List<string>();
                StringBuilder sb = new StringBuilder();

                foreach (char c in expression.Replace(" ", string.Empty))
                {
                    if (operators.IndexOf(c) >= 0)
                    {
                        if ((sb.Length > 0))
                        {
                            tokens.Add(sb.ToString());
                            sb.Length = 0;
                        }
                        tokens.Add(c.ToString());
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

                if ((sb.Length > 0))
                {
                    tokens.Add(sb.ToString());
                }
                return tokens;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {

        }
    }
}
