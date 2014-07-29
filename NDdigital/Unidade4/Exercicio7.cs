using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*Ordem crescente*/
    class Exercicio7
    {
        static void Main7()
        {
            int[] vetorA = new int[4] { 9, 3, 7, 2};
            int aux = 0;

            for (int j = 0; j <= 2; j++)
            {
                for (int i = 0; i <= 2; i++)
                {

                    if (vetorA[i] < vetorA[i + 1])// Sinal > Ordem Crescente ou Sinal < Ordem Decrescente
                    {
                        aux = vetorA[i];
                        vetorA[i] = vetorA[i + 1];
                        vetorA[i + 1] = aux;
                    }
                }
            }
            
            
            Console.WriteLine(vetorA[0]);
            Console.WriteLine(vetorA[1]);
            Console.WriteLine(vetorA[2]);
            Console.WriteLine(vetorA[3]);
            Console.ReadKey();
        }
    }
}
