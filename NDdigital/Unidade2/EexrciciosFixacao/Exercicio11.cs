using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /*11)	Faça um algoritmo que receba o preço de custo de um produto e mostre o valor de venda. 
     * Sabe-se que o preço de custo receberá um acréscimo de acordo com um percentual informado pelo usuário.*/
    class Exercicio11
    {
        static void Main()
        {
            double valorVenda = 0;
            try
            {
                Console.WriteLine("Informe o preço de custo do produto: ");
                double precoCusto = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o precentual: ");
                double precentual = double.Parse(Console.ReadLine());

                double calculaPercentual = ((precoCusto * precentual) / 100);
                valorVenda = precoCusto + calculaPercentual;

                Console.WriteLine("Valor da Venda {0} ", valorVenda + " Reais");

            }
            catch (Exception)
            {
                Console.WriteLine("Digite somente número");
            }
            Console.ReadKey();
        }
    }
}
