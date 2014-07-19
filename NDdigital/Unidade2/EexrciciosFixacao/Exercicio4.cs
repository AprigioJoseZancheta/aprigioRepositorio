using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* 4)	Escrever um algoritmo que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
       Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário no final do mês.*/
    class Exercicio4
    {
        static string nome = "Aprigio";
        static double salarioFixo = 1300;
        static double totalDeVendas = 2000;
        static double comissao = 0.15;
        static double calculaComissao;
        static double salarioFinal;
        static void Main3(string[] args)
        {
            Console.WriteLine("Nome Funcionario: {0} ", nome);
            Console.WriteLine("Salário Fixo: {0} ", salarioFixo);
            Console.WriteLine("Vendas Efetuadas: {0} ", totalDeVendas);
            Console.WriteLine("Comissão: {0} ", comissao + "%");
            calculaComissao = totalDeVendas * comissao;
            Console.WriteLine("Salário Final: {0} ", salarioFinal = calculaComissao + salarioFixo);
            Console.ReadKey();
        }
    }
}
