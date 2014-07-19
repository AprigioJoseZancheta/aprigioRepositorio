using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* 5)	Escrever um algoritmo que leia o nome de um aluno e as notas das três provas que ele obteve no semestre. 
       No final informar o nome do aluno e a sua média (aritmética).*/
    class Exercicio5
    {
        static string nome = "Aprigio";
        static double nota1;
        static double nota2;
        static double nota3;
        static double media;
        static void Main4()
        {
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome: {0} ", nome);
            Media(nota1, nota2, nota3);
        }

        static void Media(double nota1, double nota2, double nota3)
        {
            Console.WriteLine("Média: {0} ", media = ((nota1 + nota2 + nota3) / 3));
            Console.ReadKey();
        }
    }
}
