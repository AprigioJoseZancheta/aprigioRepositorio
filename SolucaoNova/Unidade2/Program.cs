using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2
{
    class Program
    {
        static int n1;
        static int n2;
        static double result;
        static string opcao;
        static void Main1()
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
            
        }

        // Exercicios Fixação
        // 1)	Faça um algoritmo que receba dois números e exiba o resultado da sua soma.
        // 2)	Faça um algoritmo que receba dois números e ao final mostre a soma, subtração, multiplicação e a divisão dos números lidos. 

        static void soma(int n1, int n2)
        {
            Console.WriteLine("Soma {0}", result = n1 + n2);
            Console.ReadKey();
        }

        static void subtracao(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("Subtração {0} ", result = n1 - n2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Subtração {0} ", result = n2 - n1);
                Console.ReadKey();
            }
        }

        static void Multiplicacao(int n1, int n2)
        {
            Console.WriteLine("Multiplicação {0} ", result = n1 * n2);
            Console.ReadKey();
        }
         
        static void Divisao(int n1, int n2)
        {
            Console.WriteLine("Divisão {0} ", result = n1 / n2);
            Console.ReadKey();
        }

        static double quantidadeLitros;
        static int distanciaPercorrida;
        static double consumoMedio;
        static void Main2()
        {
            // 3)	Escrever um algoritmo para determinar o consumo médio de um automóvel sendo fornecida a distância total percorrida pelo automóvel e o total de combustível gasto.
            Console.WriteLine("Informe a distância percorrida: ");
            distanciaPercorrida = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de litros gastos: ");
            quantidadeLitros = double.Parse(Console.ReadLine());

            ConsumoMedio(distanciaPercorrida, quantidadeLitros);
        }

        static void ConsumoMedio(int distanciaPercorrida, double quantidadeLitros)
        {
            Console.WriteLine("Consumo Medio {0} {1} ", consumoMedio = distanciaPercorrida / quantidadeLitros, "Litros");
            Console.ReadKey();
        }

        static string nome = "Aprigio";
        static double salarioFixo = 1300;
        static double totalDeVendas = 2000;
        static double comissao = 0.15;
        static double calculaComissao;
        static double salarioFinal;

        static void Main3()
        {
            // 4)	Escrever um algoritmo que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
            //Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário no final do mês.

            Console.WriteLine("Nome Funcionario: {0} ", nome);
            Console.WriteLine("Salário Fixo: {0} ", salarioFixo);
            Console.WriteLine("Vendas Efetuadas: {0} ", totalDeVendas);
            calculaComissao = totalDeVendas * comissao;
            Console.WriteLine("Salário Final: {0} ", salarioFinal = calculaComissao + salarioFixo);
            Console.ReadKey();
        }

        static double nota1;
        static double nota2;
        static double nota3;
        static double media;
        static void Main4()
        {
            // 5)	Escrever um algoritmo que leia o nome de um aluno e as notas das três provas que ele obteve no semestre. 
            //No final informar o nome do aluno e a sua média (aritmética).
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
