using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    class Exercicio6
    {
        static void Main6()
        {
            Random gera = new Random();
            int[] numeros = new int[5];
            int somaVetor = 0;
            double mediaVetor = 0;
            int contMaiorIgualMedia = 0;
            int contPositivos = 0;
            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gera.Next(30);
            }
            Console.WriteLine("Valores do Vetor");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                somaVetor += numeros[i];
                mediaVetor = somaVetor / numeros.Length;

                if (numeros[i] >= mediaVetor)
                {
                    contMaiorIgualMedia++;
                }
                if (numeros[i] > 0)
                {
                    contPositivos++;
                }
            }
            Console.WriteLine("Soma Valores do vetor {0} ", somaVetor);
            Console.WriteLine("Média Valores do vetor {0} ", mediaVetor);
            Console.WriteLine("Quantidade de valores são igual ou maior que a Média {0} ", contMaiorIgualMedia);
            Console.WriteLine("Quantidade Positivos {0} ", contPositivos);
            Console.ReadKey();
        }
    }
}
