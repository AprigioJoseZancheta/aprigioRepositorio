using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*9)  Escrever um algoritmo que leia os dados de “N” pessoas (nome, sexo, idade e saúde)  e 
     informe se está apta ou não para cumprir o serviço militar obrigatório. Informe os totais. */
    class Exercicio9
    {
        static void Main9()
        {
            string[] nomes = new string[3];
            string[] sexos = new string[3];
            string[] saude = new string[3];
            int[] idades = new int[3];
            int quantidadeAptos = 0;
            int quantidadeNaoAptos = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome do " + (i+1) +"o " + " Soldado");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite o sexo do " + (i + 1) + "o " + " Soldado");
                sexos[i] = Console.ReadLine();
                Console.WriteLine("Digite o estado de saúde do " + (i + 1) + "o " + " Soldado  (boa) ou (ruim): ");
                saude[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade do " + (i + 1) + "o " + " Soldado");
                idades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                if (saude[i] == "boa")
                {
                    quantidadeAptos++;
                }
                else if (saude[i] == "ruim")
                {
                    quantidadeNaoAptos++;
                }
            }
            Console.WriteLine("Quantidade de soldados aptos {0} ", quantidadeAptos);
            Console.WriteLine("Quantidade de soldados não aptos {0} ", quantidadeNaoAptos);
            Console.ReadKey();
        }
    }
}
