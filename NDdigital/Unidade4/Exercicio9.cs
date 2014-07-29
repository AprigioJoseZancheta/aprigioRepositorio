using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*2) Ler dois vetores A e B de tamanho 10 e 15 elementos respectivamente, em seguida geram um terceiro vetor C sendo a concatenação (junção) dos vetores: A e B.*/
    class Exercicio9
    {
        static void Main9()
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[15];
            int[,] vetorC = new int[10,15];
            Random gera = new Random();

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    vetorA[i] = gera.Next(20);
                    vetorB[j] = gera.Next(20);
                    vetorC[i, j] = vetorA[i] + vetorB[j];
                }
            }
            
            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    Console.WriteLine(vetorC[i, j]); 
                }
            }
            Console.ReadKey();
        }
    }
}
