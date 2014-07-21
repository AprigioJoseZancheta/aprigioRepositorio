using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*6)  Faça um algoritmo que receba a idade de 75 pessoas e mostre mensagem informando 
     “maior de idade” e “menor de idade” para cada pessoa. Considere a idade a partir de 18 anos 
     como maior de idade. */
    class Exercicio6
    {
        static void Main6()
        {
            Random gera = new Random();
            int[] idades = new int[75];
            int contMaior = 0;
            int contMenor = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = gera.Next(1,100);
            }
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Idades {0} ", idades[i]);
            }
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] >= 18 )
                {
                    contMaior++;
                }
                else 
                {
                    contMenor++;
                }
            }
            Console.WriteLine("Quantidade Maiores de idade {0} ", contMaior);
            Console.WriteLine("Quantidade Menores de idade {0} ", contMenor);
            Console.ReadKey();
        }
    }
}
