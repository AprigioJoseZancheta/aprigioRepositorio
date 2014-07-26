using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*15) Escrever um algoritmo que lê um valor em reais e calcula qual o menor número possível 
    de notas de 100, 50, 20, 10, 5 e 1 em que o valor lido pode ser decomposto. Escrever o valor lido 
    e a relação de notas necessárias.*/
    class Exercicio14
    {
        static void Main14()
        {
            double valor = 0;
            double notaCem = 0;
            double notaCinquenta = 0;
            double notaVinte = 0;
            double notaDez = 0;
            double notaCinco = 0;
            double notaUm = 0;
                        
            Console.WriteLine("Digite o valor: ");
            valor = double.Parse(Console.ReadLine());

            do
            {
                    if (valor >= 100)
                {
                    notaCem++;
                    valor -= 100;
                }
                else if (valor >= 50)
                {
                    notaCinquenta++;
                    valor -= 50;
                }
                else if (valor >= 20)
                {
                    notaVinte++;
                    valor -= 20;
                }
                else if (valor >= 10)
                {
                    notaDez++;
                    valor -= 10;
                }
                else if (valor >= 5)
                {
                    notaCinco++;
                    valor -= 5;
                }
                else if (valor >= 1)
                {
                    notaUm++;
                    valor -= 1;
                } 
            } while (valor != 0);
           
      
            Console.WriteLine("Quantidade notas de Cem {0} ", notaCem);
            Console.WriteLine("Quantidade notas de Cinquenta {0} ", notaCinquenta);
            Console.WriteLine("Quantidade notas de Vinte {0} ", notaVinte);
            Console.WriteLine("Quantidade notas de Dez {0} ", notaDez);
            Console.WriteLine("Quantidade notas de Cinco {0} ", notaCinco);
            Console.WriteLine("Quantidade notas de Um {0} ", notaUm);
            Console.ReadKey();
        }
    }
}
