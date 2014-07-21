using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*4)  Escrever um algoritmo que leia o nome e as três notas obtidas por um aluno durante o 
      semestre. Calcular a sua média (aritmética), informar o nome e sua menção aprovado (media 
      >= 7), Reprovado (media <= 5) e Recuperação (media entre 5.1 a 6.9). */
    class Exercicio4
    {
        static void Main4()
        {
            string nome = "";
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double media = 0;

            Console.WriteLine("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 + nota2 + nota3) / 3) ;

            Console.WriteLine("Nome aluno {0} ", nome);
            Console.WriteLine("A média é {0:F2} ", media);
            
            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media <= 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
            Console.ReadKey();
        }
    }
}
