using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoNumerico
{
    public class MinimosQuadrados
    {
        public static double[] SolucaoMMQ(int grauPolinomio, double[] xi,  double[] yi )
        {
            int linhasMatriz = grauPolinomio + 1;
            int colunasMatriz = linhasMatriz + 1;
            int length = xi.Length;

            double[] u0 = new double[length];
            for (int i = 0; i < length; i++)
            {
                u0[i] = 1;
            }
            double[] u1 = xi;
            List<double[]> lista = new List<double[]>();
            lista.Add(u0);
            lista.Add(u1);
            for (int i = 2; i <= grauPolinomio; i++)
            {
                double[] us = new double[length];
                for (int j = 0; j < length; j++)
                {
                    us[j] = Math.Pow(xi[j], i);
                }
                lista.Add(us);
            }

            double[,] matrizGeral = new double[linhasMatriz, colunasMatriz];

            for (int i = 0; i < linhasMatriz; i++)
            {
                for (int j = 0; j < linhasMatriz; j++)
                {
                    matrizGeral[i, j] = ProdutoEscalar(lista[i], lista[j]);
                }
            }

            for (int i = 0; i < matrizGeral.GetLength(0); i++)
            {
                matrizGeral[i, matrizGeral.GetLength(1) - 1] = ProdutoEscalar(lista[i], yi);
            }

            for (int i = 0; i < linhasMatriz; i++)
            {
                for (int j = 0; j < colunasMatriz; j++)
                {
                    if(double.IsInfinity(matrizGeral[i, j]))
                        throw new Exception("NÃO FOI POSSÍVEL CONCLUIR O CÁLCULO!UM OU MAIS VALORES EXCEDERAM A CAPACIDADE DE MANIPULAÇÃO DO TIPO 'DOUBLE'");
                }

            }
            return SistemaLinear.SolucionarEquacaoLinear(matrizGeral);
        }


        private static double ProdutoEscalar(double[] vetor1, double[] vetor2)
        {
            double somador = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                somador += vetor1[i] * vetor2[i];
            }
            return somador;
        }

        public static double CalculoDoErro(double[] yi, double[] xi, double[] coeficientes)
        {
            double[] yCalculado = new double[yi.Length];
            for (int i = 0; i < yi.Length; i++)
            {
                yCalculado[i] = Aproximar(coeficientes, xi[i]);

            }

            for (int i = 0; i < yCalculado.Length; i++)
            {
                yCalculado[i] -= yi[i];
            }

            double soma = 0;
            for (int i = 0; i < yCalculado.Length; i++)
            {
                soma += Math.Pow(yCalculado[i], 2);
            }

            return Math.Sqrt(soma);
        }

        public static double Aproximar(double[] coeficientes, double valor)
        {
            double resposta = 0;
            for (int j = 0; j < coeficientes.Length; j++)
            {
                resposta += (coeficientes[j] * (Math.Pow(valor, j)));
            }
            return resposta;
        }
    }
}
