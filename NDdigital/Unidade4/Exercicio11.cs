using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    class Exercicio11
    {
        static void Main11()
        {
            Random gera = new Random();
            double media = 0;
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gera.Next(10);
                
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                media += numeros[i] / 5;
            }
            Console.WriteLine("Média " + media);
            Console.ReadKey();
        }
    }
}
