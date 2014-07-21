using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*7)  Escrever um algoritmo que leia o nome e o sexo de 56 pessoas e informe o nome e se ela 
      é homem ou mulher. No final informe total de homens e de mulheres. */
    class Exercicio7
    {
        static void Main7()
        {
            string[] nomes = new string[5];
            char[] sexos = new char[5];
            int contMasculino = 0;
            int contFemenino = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe o " + (i+1) +" o" + " Nome");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Informe o " + (i + 1) + " o" + " Sexo");
                sexos[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                if (sexos[i] == 'm')
                {
                    contMasculino++;
                }
                else
                {
                    contFemenino++;
                }
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome " + nomes[i]);
                Console.WriteLine("Sexo " + sexos[i]);
            }
            Console.WriteLine("Quantidade Masculino " + contMasculino);
            Console.WriteLine("Quantidade Femenino " + contFemenino);
            Console.ReadKey();
        }
    }
}
