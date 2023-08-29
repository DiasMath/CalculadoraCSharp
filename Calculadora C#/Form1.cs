using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_C_
{
    public partial class Corpo : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Corpo()
        {
            InitializeComponent();
        }

        // Botao 0
        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        // Botao 1
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        // Botao 2
        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        // Botao 3
        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        // Botao 4
        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        // Botao 5
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        // Botao 6
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        // Botao 7
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        // Botao 8
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        // Botao 9
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        // Botao de Soma
        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "soma";
            lblOperacao.Text = "+";
        }

        // Botao de Subtração
        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "subtracao";
            lblOperacao.Text = "-";
        }

        // Botao de Multiplicação
        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "mult";
            lblOperacao.Text = "X";
        }

        // Botao de Divisão
        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "divisao";
            lblOperacao.Text = "/";
        }

        // Botao CE
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        // Botao C
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        // Botao de Igual
        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case ("soma"):
                    {
                        txtResultado.Text = Convert.ToString(valor1 + valor2);
                    }
                    break;
                case ("subtracao"):
                    {
                        txtResultado.Text = Convert.ToString(valor1 - valor2);
                    }
                    break;
                case ("mult"):
                    {
                        txtResultado.Text = Convert.ToString(valor1 * valor2);
                    }
                    break;
                case ("divisao"):
                    {
                        txtResultado.Text = Convert.ToString(valor1 / valor2);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("ERRO");
                    }
                    break;
            }
        }
    }
}

