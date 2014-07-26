using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    // Função :  Faça um programa que exibe o conteúdo de um vetor tamanho 10 de forma invertida.
    class Exercicio1
    {
        static void Main1()
        {
            Random gera = new Random();
            int[] vetorInvertido = new int[10];

            for (int i = 0; i < vetorInvertido.Length; i++)
            {
                vetorInvertido[i] = gera.Next(20);
            }
            Console.WriteLine("Sequencia Vetor");
            for (int i = 0; i < vetorInvertido.Length; i++)
            {
                Console.WriteLine(vetorInvertido[i]);
            }
            Console.WriteLine("Sequencia Vetor Invertido");
            for (int i = vetorInvertido.Length - 1; i  > 0; i --)
            {
                Console.WriteLine(vetorInvertido[i]);
            }
            Console.ReadKey();
        }
        
    }
}
