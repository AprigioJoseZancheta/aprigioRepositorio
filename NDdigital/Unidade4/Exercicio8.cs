using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*Fazer a soma dos elementos do VetorA + VetorB*/
    class Exercicio8
    {
        static void Main8()
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];
            Random gera = new Random();

            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = gera.Next(30);
            }
            Console.WriteLine("Vetor A");
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine(vetorA[i]);
            }
            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorB[i] = gera.Next(30);
            }
            Console.WriteLine("Vetor B");
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine(vetorB[i]);
            }
            for (int i = 0; i < vetorC.Length; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
            }
            Console.WriteLine("VetorC recebe Valores do VetorA + VetorB");
            for (int i = 0; i < vetorC.Length; i++)
            {
                Console.WriteLine(vetorC[i]); 
            }
            Console.ReadKey();
        }
    }
}
