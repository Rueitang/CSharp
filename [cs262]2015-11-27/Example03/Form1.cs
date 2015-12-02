using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            double number1 = 0.0;
            double number2 = 0.0;
            double number3 = 0.0;
            // bool tryBool1 = false, tryBool2 = false;
            // bool 轉成功沒 = double.TryParse(Console.ReadLine(), out number01);
            bool tryBool1 = double.TryParse(numberTextBox1.Text, out number1);
            bool tryBool2 = double.TryParse(numberTextBox2.Text, out number2);

            //  number1 = double.Parse(numberTextBox1.Text);
            //  number2 = double.Parse(numberTextBox2.Text);

            if (tryBool1 && tryBool2)
            {
                numberTextBox3.Text = (number1 + number2).ToString();
            }
            else if (!tryBool1 || !tryBool2)
            {
                MessageBox.Show("數字輸入錯誤~");
            }
        }
    }
}