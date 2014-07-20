using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /*15)	Faça um algoritmo que armazene em um vetor dos 10 nomes dos integrantes da sala. Em uma ordem que comece pelo instrutor e as primeiras fileiras até as últimas. 
     * No final, mostre na tela de forma contrária do último ao instrutor. Você deve escrever e armazenar o nome dos 5. */
    class Exercicio15
    {
        static void Main()
        {
            string[] nomes = new string[] { "Thiago", "Luiz", "Lucas", "Camila", "Greicy", "Arnaldo", "Guilherme", "Raul", "Aprigio", "Rafael" };

            Console.WriteLine("Mostra em ordem");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome " + (i + 1) + "o " + nomes[i]);
            }
            Console.WriteLine("####################################");
            Console.WriteLine("Mostra em Invertida");
            for (int i = 9; i > -1; i--)
            {
                Console.WriteLine("Nome Invertidos " + (i + 1) + "o " + nomes[i]);
            }
            Console.WriteLine("####################################");
            Console.WriteLine("Mostra os 5 Primeiros");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome " + (i + 1) + "o " + nomes[i]);
            }
            Console.ReadKey();
        }
    }
}
