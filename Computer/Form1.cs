using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        public double value = 0;
        public string operation = "";
        public bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            AnswerLabel.Text = "0";
        }

        public void ClearButton_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((AnswerLabel.Text == "0") || (operation_pressed))
                AnswerLabel.Text = "";

            operation_pressed = false;
            Button number = (Button)sender;
            AnswerLabel.Text += number.Text;
        }

        public void operator_click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            operation = number.Text;
            value = double.Parse(AnswerLabel.Text);
            operation_pressed = true;
            equation.Text = value + "" + operation;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    AnswerLabel.Text = (value + double.Parse(AnswerLabel.Text)).ToString();
                    break;

                case "-":
                    AnswerLabel.Text = (value - double.Parse(AnswerLabel.Text)).ToString();
                    break;

                case "*":
                    AnswerLabel.Text = (value * double.Parse(AnswerLabel.Text)).ToString();
                    break;

                case "/":
                    AnswerLabel.Text = (value / double.Parse(AnswerLabel.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}