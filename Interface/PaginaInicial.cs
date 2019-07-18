using CalculoNumerico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class PaginaInicial : Form
    {
        public List<double> Resposta { get; set; }
        public List<double> Xi { get; set; }
        public List<double> Yi { get; set; }

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            Resposta = new List<double>();
            Xi = new List<double>();
            Yi = new List<double>();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {     
            try
            {
                List<double> xi = new List<double>();
                List<double> yi = new List<double>();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        xi.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
                        yi.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));
                    }
                }

                if(xi.Count() == 0 || yi.Count() == 0)
                {
                    MessageBox.Show($"UM OU MAIS CAMPOS OBRIGATÓRIOS NÃO FORAM PREENCHIDOS!");
                }                 
                else
                {
                    int grau = Convert.ToInt32(numGrauPolinomio.Value);
                    Xi = xi;
                    Yi = yi;

                    CalcularResposta(xi, yi, grau);
                }                   
            }
            catch (FormatException)
            {
                MessageBox.Show($"UM OU MAIS VALORES INFORMADOS NÃO ESTAVAM NO FORMATO CORRETO!");
                LimparGeral();
            }
            catch (Exception erro2)
            {
                MessageBox.Show($"ATENÇÃO:\n\n{erro2.Message}");
                LimparGeral();
            }               
        }

        private void CalcularResposta(List<double> xi, List<double> yi, int grau)
        {
            Resposta.Clear();

            Resposta = MinimosQuadrados.SolucaoMMQ(grau, xi, yi);
            
            double erro = MinimosQuadrados.CalculoDoErro(yi, xi, Resposta);

            PreencherRespostas(Resposta, erro);
        }

        private void PreencherRespostas(List<double> resposta, double erro)
        {
            int tamanho = resposta.Count();
            LimparX();
            txtResposta.Text = " " + AdaptarCasasDecimais(resposta[0]) + " + ";
            for (int i = 1; i < tamanho; i++)
            {
                txtResposta.Text += AdaptarCasasDecimais(resposta[i]) + "x^" + i;
                if (i - tamanho != -1)
                    txtResposta.Text += " + ";

            }
            txtErro.Text = AdaptarCasasDecimais(erro);
        }

        private string AdaptarCasasDecimais(double valor)
        {
            try
            {
                double value = valor;
                if (value < 0)
                    value *= -1;
                long valorInteiro = Convert.ToInt64(Math.Floor(value));
                double casasDecimais = value - valorInteiro;
                if (casasDecimais == 0)
                    return Convert.ToString(valor.ToString("F0"));
                else if (casasDecimais < 0.00000001)
                    return Convert.ToString(valor);
                else if (casasDecimais > 0.00000001 && casasDecimais < 0.000001)
                    return Convert.ToString(valor.ToString("F8"));
                else if (casasDecimais > 0.000001 && casasDecimais < 0.0001)
                    return Convert.ToString(valor.ToString("F6"));
                else
                    return Convert.ToString(valor.ToString("F4"));
            }
            catch (Exception)
            {
                return Convert.ToString(valor.ToString("F4"));
            }
        }

        private void BtnResultadoX_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtValorX.Text);
                txtResultadoX.Text = AdaptarCasasDecimais((MinimosQuadrados.Aproximar(Resposta, x)));
            }
            catch (Exception)
            {
                MessageBox.Show("DADOS AUSENTES OU INSUFICIENTES PARA UMA PREVISÃO!");
            }
        }
          
        private void Gerar_Click(object sender, EventArgs e)
        {
            if (Resposta.Count != 0)
            {
                Grafico grafico = new Grafico();
                grafico.GerarGrafico(Xi, Yi, Resposta, txtResposta.Text);
                grafico.Show();
            }
            else
            {
                MessageBox.Show("DADOS AUSENTES OU INSUFICIENTES PARA GERAR UM GRÁFICO!");
            }
        }

        private void LimparGeral()
        {
            txtResposta.Clear();
            txtErro.Clear();
            Resposta.Clear();
            Xi.Clear();
            Yi.Clear();
            LimparX();
        }

        private void LimparX()
        {
            txtResultadoX.Clear();
            txtValorX.Clear();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LimparGeral();
        }

        private void LimparPrevisao_Click(object sender, EventArgs e)
        {
            LimparX();
        }

        private void TxtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == '.')))
                e.Handled = true;
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
                e.Control.KeyPress += new KeyPressEventHandler(DataGridView1_KeyPress);
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsControl(e.KeyChar)) || (e.KeyChar == '.') || (e.KeyChar == '-')))
                e.Handled = true;
        }
    }
}
