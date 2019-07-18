using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculoNumerico
{
    public class MinimosQuadrados
    {
        public static List<double> SolucaoMMQ(int grauPolinomio, List<double> xi,  List<double> yi )
        {
            int linhasMatriz = grauPolinomio + 1;
            int colunasMatriz = linhasMatriz + 1;
            int length = xi.Count();

            //Criação de u0 e u1, que são padronizados:
            List<double> u0 = new List<double>();
            List<double> u1 = new List<double>();
            for (int i = 0; i < length; i++)
            {
                u0.Add(1);
                u1.Add(xi[i]);
            }

            //Cria-se uma lista de vetores double para acomodar todos os U's, uma vez que não se sabe quantos serão
            List<List<double>> lista = new List<List<double>>();
            lista.Add(u0);
            lista.Add(u1);
            for (int i = 2; i <= grauPolinomio; i++)
            {
                List<double> us = new List<double>();
                for (int j = 0; j < length; j++)
                {
                    us.Add(Math.Pow(xi[j], i));
                }
                lista.Add(us);
            }

            //Cria-se a matriz que acomodará os produtos escalares
            double[,] matrizGeral = new double[linhasMatriz, colunasMatriz];

            for (int i = 0; i < linhasMatriz; i++)
            {
                for (int j = 0; j < linhasMatriz; j++) 
                {
                    matrizGeral[i, j] = ProdutoEscalar(lista[i], lista[j]);
                }
            }

            for (int i = 0; i < linhasMatriz; i++)
            {
                matrizGeral[i, colunasMatriz - 1] = ProdutoEscalar(lista[i], yi);
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


        private static double ProdutoEscalar(List<double> lista1, List<double> Yi)
        {
            double somador = 0;
            for (int i = 0; i < lista1.Count(); i++)
            {
                somador += lista1[i] * Yi[i];
            }
            return somador;
        }

        public static double CalculoDoErro(List<double> yi, List<double> xi, List<double> coeficientes)
        {
            List<double> yCalculado = new List<double>();
            for (int i = 0; i < yi.Count(); i++)
            {
                yCalculado.Add(Aproximar(coeficientes, xi[i]));

            }

            for (int i = 0; i < yCalculado.Count(); i++)
            {
                yCalculado[i] -= yi[i];
            }

            double soma = 0;
            for (int i = 0; i < yCalculado.Count(); i++)
            {
                soma += Math.Pow(yCalculado[i], 2);
            }

            return Math.Sqrt(soma);
        }

        public static double Aproximar(List<double> coeficientes, double valor)
        {
            double resposta = 0;
            for (int j = 0; j < coeficientes.Count(); j++)
            {
                resposta += (coeficientes[j] * (Math.Pow(valor, j)));
            }
            return resposta;
        }
    }
}
