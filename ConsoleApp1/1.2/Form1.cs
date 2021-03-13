using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 =int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            switch (comboBox1.SelectedItem)
            {
                case "+":
                    textBox3.Text = ""+(num1 + num2);
                    break;
                case "-":
                    textBox3.Text = "" + (num1 - num2);
                    break;
                case "*":
                    textBox3.Text = "" +( num1 * num2);
                    break;
                case "/":
                    textBox3.Text = "" + (num1 / num2);
                    break;
                default:
                    MessageBox.Show("请选择正确的运算符");
                    textBox3.Text = "";
                    break;
            }
        }
    }
}
