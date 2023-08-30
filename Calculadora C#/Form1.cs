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
        // Variaveis
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Corpo()
        {
            InitializeComponent();
        }

        // Botao Ponto
        private void btnPonto_Click(object sender, EventArgs e)
        {
            AtribuirValorBotao(".");
        }

        // Botao 0
        private void btnZero_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("0");
        }

        // Botao 1
        private void btnUm_Click(object sender, EventArgs e)
        {
            AtribuirValorBotao("1");
        }

        // Botao 2
        private void btnDois_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("2");
        }

        // Botao 3
        private void btnTres_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("3");
        }

        // Botao 4
        private void btnQuatro_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("4");
        }

        // Botao 5
        private void btnCinco_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("5");
        }

        // Botao 6
        private void btnSeis_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("6");
        }

        // Botao 7
        private void btnSete_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("7");
        }

        // Botao 8
        private void btnOito_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("8");
        }

        // Botao 9
        private void btnNove_Click(object sender, EventArgs e)
        {

            AtribuirValorBotao("9");
        }

        // Botao de Adição
        private void btnAdicao_Click(object sender, EventArgs e)
        {

            ValidarOperacao("soma", "+");
        }

        // Botao de Subtração
        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            ValidarOperacao("subtracao", "-");
        }

        // Botao de Multiplicação
        private void btnMult_Click(object sender, EventArgs e)
        {

            ValidarOperacao("mult", "X");
        }

        // Botao de Divisão
        private void btnDivisao_Click(object sender, EventArgs e)
        {

            ValidarOperacao("divisao", "/");
        }

        // Botao CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        // Botao C
        private void bntC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        // Botao de Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {

            if(txtResultado.Text != "")
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
                            MessageBox.Show("Informe um valor para realizar a operação.");
                        }
                        break;
                }

            }
        }

        public void ValidarOperacao(string nomeOperacao, string simboloOperacao)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = nomeOperacao;
                lblOperacao.Text = simboloOperacao;

            }
            else
            {
                MessageBox.Show("Informe um valor para realizar a operação.");
            }
        }

        public void AtribuirValorBotao(string valorBotao)
        {
            txtResultado.Text += valorBotao;
        }
    }
}


