using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*1) Declarar um vetor de 20 números inteiros, em seguida ler os elementos do vetor, e ao final mostrar somente os número positivos, 
     * e mostrar ainda a quantidade de positivos, a quantidade de negativos e a quantidade de nulos (0).*/
    class Exercicio2
    {
        static void Main2()
        {
            Random gera = new Random();
            int[] numeros = new int[20];
            double contPositivo = 0;
            double contNegativo = 0;
            double contZeros = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gera.Next(-30, 30);
            }
            Console.WriteLine("Mostra lista original");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("Mostra so Positivos");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine(numeros[i]);
                    contPositivo++;
                }
                else if (numeros[i] < 0)
                {
                    contNegativo++;
                }
                else if (numeros[i] == 0)
                {
                    contZeros++;
                }
            }
            Console.WriteLine("Quantidade de números positivos {0} ", contPositivo);
            Console.WriteLine("Quantidade de números negativos {0} ", contNegativo);
            Console.WriteLine("Quantidade de números iguais a zero {0} ", contZeros);
            Console.ReadKey();
        }
    }
}
