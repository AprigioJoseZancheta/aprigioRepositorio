using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*10)  Faça um algoritmo que receba o preço de custo e o preço de venda de 40 produtos. 
        Mostre como resultado se houve lucro, prejuízo ou empate para cada produto. Informe média
        de preço de custo e do preço de venda. */
    class Exercicio10
    {
        static void Main10()
        {
            double[] precoCusto = new double[3];
            double[] precoVenda = new double[3];
            double mediaPrecoCusto = 0;
            double mediaPrecoVenda = 0;

            for (int i = 0; i < precoCusto.Length; i++)
            {
                Console.WriteLine("Informe o preço de custo do " + (i+1) +"o " + "Produto");
                precoCusto[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o preço de venda do " + (i + 1) + "o " + "Produto");
                precoVenda[i] = double.Parse(Console.ReadLine());

                if (precoVenda[i] > precoCusto[i])
                {
                    Console.WriteLine("Deu lucro");
                }
                else if (precoCusto[i] > precoVenda[i])
                {
                    Console.WriteLine("Deu Prejuízo");
                }
                else if (precoCusto[i] == precoVenda[i])
                {
                    Console.WriteLine("Deu Empate");
                }

                mediaPrecoCusto += precoCusto[i] / 3;
                mediaPrecoVenda += precoVenda[i] / 3;
            }
            Console.WriteLine("Média preço de custo {0:F2} ", mediaPrecoCusto);
            Console.WriteLine("Média preço de venda {0:F2} ", mediaPrecoVenda);
            Console.ReadKey();
        }
    }
}
