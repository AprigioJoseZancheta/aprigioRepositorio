using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2
{
    class Program
    {
        static int n1;
        static int n2;
        static double result;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Número");
            n2 = int.Parse(Console.ReadLine());

            soma(n1, n2);
        }

        // Exercicios Fixação
        // 1)	Faça um algoritmo que receba dois números e exiba o resultado da sua soma.  

        static void soma(int n1, int n2)
        {
            Console.WriteLine("Soma {0}", result = n1 + n2);
            Console.ReadKey();
        }
    }
}
