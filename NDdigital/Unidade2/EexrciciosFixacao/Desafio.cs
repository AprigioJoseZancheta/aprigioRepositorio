using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    class Desafio
    {
        /* 
        Escreva um algoritmo que leia três números inteiros e positivos (A, B, C) e calcule a seguinte expressão:*/

        static void Main15()
        {
            try
            {
                int a = 0;
                int b = 0;
                int c = 0;
                double r = 0;
                double s = 0;
                double d = 0;

                Console.WriteLine("Digite um valor de A: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor de B: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor de C: ");
                c = int.Parse(Console.ReadLine());

                r = ((a + b) * (a + b));
                s = ((b + c) * (b + c));

                d = ((r + s) / 2);
                Console.WriteLine("Valor de D: {0} ", d);
                
            }
            catch (Exception)
            {

                Console.WriteLine("Somente Números");
            }
            Console.ReadKey();
        }
    }
}
