using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool operator1hasDot, operator2hasDot, hasOperation;

        public Form1()
        {
            InitializeComponent();
            operator1hasDot = false;
            operator2hasDot = false;
            hasOperation = false;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            buttonOperationEquals.Focus();
            if (but.Text == "DEL")
                HandleCharacter((char)Keys.Back);
            else if (but.Text == "DOT")
                HandleCharacter('.');
            else
                HandleCharacter(but.Text[0]);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            HandleCharacter(e.KeyChar);
        }

        private void HandleCharacter(char c)
        {
            if (textBox.Text != "")
            {
                if (c >= '0' && c <= '9')
                {
                    if (textBox.Text[textBox.Text.Length - 1] == '0' && (textBox.Text.Substring(0, textBox.Text.Length - 1) == "" || textBox.Text[textBox.Text.Length - 2] == '/' || textBox.Text[textBox.Text.Length - 2] == '+' || textBox.Text[textBox.Text.Length - 2] == '-' || textBox.Text[textBox.Text.Length - 2] == '*'))
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1) + c;
                    else
                        textBox.Text += c;
                }
                else if (c == '/' || c == '*' || c == '+')
                {
                    if (textBox.Text[textBox.Text.Length - 1] >= '0' && textBox.Text[textBox.Text.Length - 1] <= '9')
                    {
                        if(hasOperation == true)
                        {
                            Equals();
                        }
                        hasOperation = true;
                        textBox.Text += c;
                    }
                    else if (textBox.Text[textBox.Text.Length - 1] == '/' || textBox.Text[textBox.Text.Length - 1] == '*' || textBox.Text[textBox.Text.Length - 1] == '+')
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1) + c;
                    else if (textBox.Text[textBox.Text.Length - 2] >= '0' && textBox.Text[textBox.Text.Length - 2] <= '9' && textBox.Text[textBox.Text.Length - 1] == '-')
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1) + c;
                }
                else if (c == (char)Keys.Back)
                {
                    if (textBox.Text[textBox.Text.Length - 1] == '/' || textBox.Text[textBox.Text.Length - 1] == '+' || textBox.Text[textBox.Text.Length - 1] == '*')
                        hasOperation = false;
                    if(textBox.Text[textBox.Text.Length - 1] == '.')
                    {
                        if (hasOperation == false)
                        {
                            if (operator1hasDot == true)
                            {
                                operator1hasDot = false;
                            }
                        }
                        else if (operator2hasDot == true)
                        {
                            operator2hasDot = false;
                        }
                    }
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
                else if (c == '.')
                {
                    if(hasOperation == false)
                    {
                        if (operator1hasDot == false)
                        {
                            operator1hasDot = true;
                            textBox.Text += c;
                        }
                    }
                    else if(operator2hasDot == false)
                    {
                        operator2hasDot = true;
                        if (textBox.Text[textBox.Text.Length - 1] == '/' || textBox.Text[textBox.Text.Length - 1] == '+' || textBox.Text[textBox.Text.Length - 1] == '-' || textBox.Text[textBox.Text.Length - 1] == '*')
                            textBox.Text += '0';
                        textBox.Text += c;
                    }
                }
                else if (c == '-')
                {
                    if (textBox.Text[textBox.Text.Length - 1] >= '0' && textBox.Text[textBox.Text.Length - 1] <= '9')
                    {
                        if (hasOperation == true)
                        {
                            Equals();
                        }
                        hasOperation = true;
                        textBox.Text += c;
                    }
                    else if(textBox.Text[textBox.Text.Length - 1] == '/' || textBox.Text[textBox.Text.Length - 1] == '*' || textBox.Text[textBox.Text.Length - 1] == '+')
                    {
                        textBox.Text += c;
                    }
                    else if(textBox.Text[textBox.Text.Length - 2] >= '0' && textBox.Text[textBox.Text.Length - 2] <= '9' && textBox.Text[textBox.Text.Length - 1] == '-')
                    {
                        textBox.Text += c;
                    }
                }
                else if (c == '=' || c == (char)Keys.Return)
                {
                    if(hasOperation == true || (textBox.Text[textBox.Text.Length - 1] >= '0' && textBox.Text[textBox.Text.Length - 1] <= '9'))
                    {
                        Equals();
                        hasOperation = false;
                    }
                }
            }
            else
            {
                if (c >= '0' && c <= '9')
                {
                    textBox.Text += c;
                }
                else if(c == '.')
                {
                    textBox.Text += '0';
                    textBox.Text += c;
                }
                else if(c == '-')
                {
                    textBox.Text += c;
                }
            }
        }

        private void Equals()
        {
            double op1 = 0, op2 = 0;
            char op = '+';
            //string result = Regex.Match(textBox.Text, @"^(-?\d+(\.?\d+)?)([-+*\/])(-?\d+(\.?\d+)?)$").Value;

            Match match = Regex.Match(textBox.Text, @"^(-?\d+\.?\d*)([-+*\/])(-?\d+\.?\d*)$");
            //Console.WriteLine(match.Groups[1].Value + ' ' + match.Groups[2].Value + ' ' + match.Groups[3].Value);
            try
            {
                op1 = Double.Parse(match.Groups[1].Value);
                op2 = Double.Parse(match.Groups[3].Value);
                op = match.Groups[2].Value[0];
            }
            catch(Exception exeption)
            {
                Console.WriteLine(exeption);
            }

            double result = 0;

            switch (op)
            {
                case '+': 
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    result = 0;
                    break;
            }

            textBox.Text = result.ToString();
            if (result == (int)result)
                operator1hasDot = false;
            operator2hasDot = false;
        }
    }
}
