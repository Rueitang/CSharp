using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpLabel.Text = "+";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpLabel.Text = "-";
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text = "*";
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text = "/";
        }

        private void OpButton_Click(object sender, EventArgs e)
        {
            double number1 = 0.0;
            double number2 = 0.0;
            double number3 = 0.0;

            bool tryBool1 = double.TryParse(numberTextBox1.Text, out number1);
            bool tryBool2 = double.TryParse(numberTextBox2.Text, out number2);

            if (!tryBool1 || !tryBool2)
            {
                MessageBox.Show("數字輸入錯誤~");
            }
            else if (tryBool1 && tryBool2)
            {
                if (OpLabel.Text == "+")
                    numberTextBox3.Text = (number1 + number2).ToString();
                else if (OpLabel.Text == "-")
                    numberTextBox3.Text = (number1 - number2).ToString();
                else if (OpLabel.Text == "*")
                    numberTextBox3.Text = (number1 * number2).ToString();
                else if (OpLabel.Text == "/")
                    numberTextBox3.Text = (number1 / number2).ToString();
            }
        }
    }
}