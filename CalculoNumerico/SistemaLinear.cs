using System;
using System.Collections.Generic;

namespace CalculoNumerico
{
    public class SistemaLinear
    {
        public static List<double> SolucionarEquacaoLinear(double[,] matrizGeral)
        {
            if (matrizGeral.GetLength(0) + 1 == matrizGeral.GetLength(1))
            {
                int numEquacoes = matrizGeral.GetLength(0);

                for (int i = 0; i < numEquacoes; i++)
                {
                    // Verifica se o elemento da diagonal principal é diferente de zero
                    if (matrizGeral[i, i] == 0)
                    {
                        int j;
                        //Caso não seja, soma a linha em questão com a linha de baixo (ou com a próxima linha que 
                        // contenha um elemento não nulo na coluna em questão
                        for (j = i + 1; j < numEquacoes; j++)
                        {
                            if (matrizGeral[j, i] != 0)
                            {
                                for (int k = i; k < numEquacoes + 1; k++)
                                    matrizGeral[i, k] += matrizGeral[j, k];
                                break;
                            }
                        }
                        if (j == numEquacoes)
                            throw new Exception("NÃO FOI POSSÍVEL SOLUCIONAR O SISTEMA LINEAR!\nAS POSSÍVEIS CAUSAS SÃO:\n# DADOS INSUFICIENTES PARA O GRAU DO POLINÔMIO SOLICITADO;\n# UM OU MAIS DADOS SE REPETEM;\n# DADOS INCONSISTENTES.");
                    }

                    //faz o elemento da diagonal principal igual a  1, dividindo toda a linha por ele 
                    for (int k = numEquacoes; k >= i; k--)
                        matrizGeral[i, k] /= matrizGeral[i, i];

                    //Zera os elementos da coluna que não são da diagonal principal (deixa a matriz na forma escada)
                    for (int j = i + 1; j < numEquacoes; j++)
                    {
                        for (int k = numEquacoes; k >= i; k--)
                            matrizGeral[j, k] -= matrizGeral[i, k] * matrizGeral[j, i];
                    }   
                }

                // Termina o escalonamento, deixando a matriz na forma escada reduzida
                for (int i = numEquacoes - 1; i > 0; i--)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        matrizGeral[j, numEquacoes] -= matrizGeral[j, i] * matrizGeral[i, numEquacoes];
                        matrizGeral[j, i] = 0;
                    }
                }

                List<double> solucao = new List<double>();
                for (int j = 0; j < numEquacoes; j++)
                    solucao.Add(matrizGeral[j, numEquacoes]);

                return solucao;
            }
            else
                throw new Exception("OS DADOS FORNECIDOS SÃO INSUFICIENTES PARA O GRAU DO POLINÔMIO SOLICITADO!");
        }
    }
}
