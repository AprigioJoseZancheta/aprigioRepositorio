using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*3)  Faça um algoritmo que receba um número e diga se este número está no intervalo entre 
    100 e 200. */
    class Exercicio3
    {
        static void Main3()
        {
            int numero = 0;

            Console.WriteLine("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 100 && numero <= 200)
            {
                Console.WriteLine("O número está entre 100 e 200");
            }
            else
            {
                Console.WriteLine("O número não está entre 100 e 200");
            }
            Console.ReadKey();
        }
    }
}
