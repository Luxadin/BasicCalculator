using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        double previousNumber;
        char lastoperation;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void playSimpleSound()
        {
            // plays sound at the file path
            // will only work if you have the Window Media Player library active under COM Object in Add References

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Luxad\Desktop\Applied.mp3";
            player.controls.play();
            /*SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Luxad\Desktop\Applied.mp3");
            simpleSound.Play();*/

        }

        private void operationPressed()
        {
            previousNumber = Convert.ToDouble(InputBox.Text);
            InputBox.Clear();
            Console.WriteLine("Previous Number:" + previousNumber);
        }

        private void startNewEquation()
        {
            InputBox.Clear();
            previousNumber = 0;
            lastoperation = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("1");
            playSimpleSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (lastoperation == '=')
            {
                startNewEquation();
            }
            InputBox.AppendText("0");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            /*currentNumber = Convert.ToInt32(InputBox.Text);
            InputBox.Clear();
            Console.Write(currentNumber);*/
            operationPressed();
            lastoperation = '+';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operationPressed();
            lastoperation = '-';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operationPressed();
            lastoperation = '*';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operationPressed();
            lastoperation = '/';
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //int currentNumber = Convert.ToInt32(InputBox.Text);
            double currentNumber = Convert.ToDouble(InputBox.Text);
            Console.WriteLine("Current Number:" + currentNumber);
            if (lastoperation == '+')
            {
                InputBox.Text = (previousNumber + currentNumber).ToString();
            }
            else if (lastoperation == '-')
            {
                InputBox.Text = (previousNumber - currentNumber).ToString();
            }
            else if (lastoperation == '*')
            {
                InputBox.Text = (previousNumber * currentNumber).ToString();
            }
            else if (lastoperation == '/')
            {
                InputBox.Text = (previousNumber / currentNumber).ToString();
            }
            else
            {

            }
            lastoperation = '=';
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            startNewEquation();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
             if (lastoperation == '=')
            {
                startNewEquation();
            }
            else if (InputBox.Text == "0" || InputBox.Text == "")
            {
                InputBox.AppendText("0.");
            }
             else
            {
                InputBox.AppendText(".");
            }
        }
    }
}
