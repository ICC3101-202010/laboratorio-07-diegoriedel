using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        double result_value=0;
        string operador = "";
        bool operation = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void numero1_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || operation)
                textBox_Result.Clear();
            operation = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
       
        }

        private void sumar_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operador = button.Text;
            result_value = double.Parse(textBox_Result.Text);
            CurrentOperator.Text = result_value + " " + operation;
            operation = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result_value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":

                    textBox_Result.Text = (result_value + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":

                    textBox_Result.Text = (result_value - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":

                    textBox_Result.Text = (result_value / double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":

                    textBox_Result.Text = (result_value * double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
