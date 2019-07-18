using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class Grafico : Form
    {

        public Grafico()
        {
            InitializeComponent();
        }

        public void GerarGrafico(List<double> xi, List<double> yi, List<double> resposta, string titulo)
        {
            graficos.Titles[0].Text = "GRÁFICO DA APROXIMAÇÃO " + titulo;
            double valorX = xi[0];
            double parada = xi[xi.Count() - 1] +2;
            while (valorX < parada)
            {
                double ponto = 0;
                for (int j = 0; j < resposta.Count(); j++)
                {
                    ponto += resposta[j] * Math.Pow(valorX, j);
                }
               graficos.Series[0].Points.AddXY(valorX, ponto);
                valorX += 1;
            }
            for (int i = 0; i < xi.Count(); i++)
            {
                graficos.Series[1].Points.AddXY(xi[i], yi[i]);
            }
        }
    }
}
