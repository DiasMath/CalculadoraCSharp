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
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        public enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Corpo()
        {
            InitializeComponent();
        }

        // Botao Virgula
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                AtribuirValorBotao(",");
            }
        }

        // Botao 0
        private void btnZero_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text == "" || txtResultado.Text != "0")
            {
                AtribuirValorBotao("0");
            }
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

            ValidarOperacao(Operacao.Adicao, "+");
        }

        // Botao de Subtração
        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            ValidarOperacao(Operacao.Subtracao, "-");
        }

        // Botao de Multiplicação
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

            ValidarOperacao(Operacao.Multiplicacao, "X");
        }

        // Botao de Divisão
        private void btnDivisao_Click(object sender, EventArgs e)
        {

            ValidarOperacao(Operacao.Divisao, "/");
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
            LimparTudo();
        }

        // Botao de Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "")
            {
                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        {
                            Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        }
                        break;
                    case Operacao.Subtracao:
                        {
                            Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        }
                        break;
                    case Operacao.Multiplicacao:
                        {
                            Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        }
                        break;
                    case Operacao.Divisao:
                        {
                            Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Erro! Informe um valor!");
                        }
                        break;
                }

                lblOperacao.Text = "=";
                txtResultado.Text = Convert.ToString(Resultado);
            }
            else
            {
                MessageBox.Show("Realize uma operação antes!");
            }
        }

        public void ValidarOperacao(Operacao operacao, string simboloOperacao)
        {
            if (txtResultado.Text != "")
            {
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                OperacaoSelecionada = operacao;
                lblOperacao.Text = simboloOperacao;

            }
            else
            {
                MessageBox.Show($"Para realizar uma {operacao}, informe um valor.");
            }
        }

        public void AtribuirValorBotao(string valorBotao)
        {
            txtResultado.Text += valorBotao;
        }

        public void LimparTudo()
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            Valor = 0;
        }
    }
}