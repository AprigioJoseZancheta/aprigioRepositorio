using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* Exercicios Fixação
       1)	Faça um algoritmo que receba dois números e exiba o resultado da sua soma.
       2)	Faça um algoritmo que receba dois números e ao final mostre a soma, subtração, multiplicação e a divisão dos números lidos.*/
    class Eexrcicio1e2
    {
        static int n1;
        static int n2;
        static double result;
        static string opcao;
        static void Main1(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo Número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite opção (1) para Soma\n Digite opção (2) para Subtração\n Digite opção (3) para Multiplicação\n Digite opção (4) para Divisão");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                         soma(n1, n2);
                break;
                    
                case "2":
                        subtracao(n1, n2);
                break;

                case "3":
                Multiplicacao(n1, n2);
                break;

                case "4":
                Divisao(n1, n2);
                break;

                default: Console.WriteLine("Opção Inválida");
                break;
            }
            Console.ReadKey();
        }

        static void soma(int n1, int n2)
        {
            Console.WriteLine("Soma {0}", result = n1 + n2);
        }

        static void subtracao(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("Subtração {0} ", result = n1 - n2);
            }
            else
            {
                Console.WriteLine("Subtração {0} ", result = n2 - n1);
            }
        }

        static void Multiplicacao(int n1, int n2)
        {
            Console.WriteLine("Multiplicação {0} ", result = n1 * n2);
        }
         
        static void Divisao(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("Divisão {0} ", result = n1 / n2); 
            }
            else
            {
                Console.WriteLine("Divisão {0} ", result = n2 / n1); 
            }
        }
        
    }
}
