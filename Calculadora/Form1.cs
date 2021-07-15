using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
   
    public partial class Form1 : Form
    {
        int n1, n2, op = 0, calculo;
        float v1, v2, divisao;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + "9";
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {

            n1 = int.Parse(textBox_display.Text);
            textBox_display.Text = "";
            op = 2;
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox_display.Text);
            textBox_display.Text = "";
            op = 3;
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            textBox_display.Text = textBox_display.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            v1 = int.Parse(textBox_display.Text);
            textBox_display.Text = "";
            op = 4;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case 1:
                    n2 = int.Parse(textBox_display.Text);
                    calculo = n1 + n2;
                    textBox_display.Text = Convert.ToString(calculo);
                    break;
                case 2:
                    n2 = int.Parse(textBox_display.Text);
                    calculo = n1 - n2;
                    textBox_display.Text = Convert.ToString(calculo);
                    break;
                case 3:
                    n2 = int.Parse(textBox_display.Text);
                    calculo = n1 * n2;
                    textBox_display.Text = Convert.ToString(calculo);
                    break;
                case 4:
                    v2 = int.Parse(textBox_display.Text);
                    divisao = v1 / v2;
                    textBox_display.Text = Convert.ToString(divisao, CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_display.Text = "";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            
            n1 = int.Parse(textBox_display.Text);
            textBox_display.Text = "";
            op = 1;
        }
    }
}
