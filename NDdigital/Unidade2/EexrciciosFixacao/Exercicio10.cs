using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /*10)	A Loja Mamão com Açúcar está vendendo seus produtos em 5 (cinco) prestações sem juros. 
     * Faça um algoritmo que receba um valor de uma compra e mostre o valor das prestações.*/
    class Exercicio10
    {
        static void Main9()
        {
            double valorPrestacao;
            try
            {
                Console.WriteLine("Informe o valor da compra: ");
                double valorCompra = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de Prestações: ");
                int quantidadePrestacao = int.Parse(Console.ReadLine());

                valorPrestacao = valorCompra / quantidadePrestacao;
                Console.WriteLine("Valor Prestação: {0} ", valorPrestacao + " Reais");

            }
            catch (Exception)
            {

                Console.WriteLine("Digite somente número");
            }
            Console.ReadKey();
        }
    }
}
