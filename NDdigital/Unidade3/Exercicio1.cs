using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*1)  Faça um algoritmo que receba um número e mostre uma mensagem caso este número 
      seja maior que 10. */
    class Exercicio1
    {
        static void Main1()
        {
            int numero = 0;

            Console.WriteLine("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("Número maior que 10");
            }
            else
            {
                Console.WriteLine("Número menor que 10");
            }
            Console.ReadKey();
        }
    }
}
