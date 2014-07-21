using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*2) Escrever um algoritmo que leia dois valores inteiro distintos e informe qual é o maior.*/
    class Exercicio2
    {
        static void Main2()
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Informe o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("Primeiro número maior que o segundo");
            }
            else
            {
                Console.WriteLine("Segundo número maior que o primeiro");
            }
            Console.ReadKey();

        }
    }
}
