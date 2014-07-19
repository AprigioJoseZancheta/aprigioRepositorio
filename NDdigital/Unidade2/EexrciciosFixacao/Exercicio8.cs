using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /*8) Elaborar um algoritmo que efetue a apresentação do valor da conversão em real (R$) de um valor lido em dólar (US$). 
      O algoritmo deverá solicitar o valor da cotação do dólar e também a quantidade de dólares disponíveis com o usuário.*/
    class Exercicio8
    {
        static double dolar;
        static double real;
        static double cotacao = 2.22;
        static double converte;

        static void Main7()
        {
            try
            {
                Console.WriteLine("Informe a quantidade de dolares que deseja converter em real: ");
                dolar = double.Parse(Console.ReadLine());
                converte = dolar * cotacao;

                Console.WriteLine("Cotação do dolar: {0}, Valor em real: {1} ", cotacao, converte);
            }
            catch (Exception erro)
            {

                Console.WriteLine("Por Favor digite um número");
            }
          
            Console.ReadKey();
        }
    }
}
