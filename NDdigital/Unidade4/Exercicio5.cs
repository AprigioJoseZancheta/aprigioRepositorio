using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*Descobrir o maior e o menor número do vetor*/
    class Exercicio5
    {
        static void Main5()
        {
            int maior = 0;
            int menor = 99;
            Random gera = new Random();
            int[] numero = new int[10];

            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = gera.Next(50);
            }
            Console.WriteLine("Lista Original");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
                if (numero[i] > maior)
                {
                    maior = numero[i];
                    
                }
                else if (numero[i] < menor)
                {
                    menor = numero[i]; 
                }
            }
            Console.WriteLine("Mostra maior {0} ", maior);
            Console.WriteLine("Mostra menor {0} ", menor);
            Console.ReadKey();
        }
    }
}
