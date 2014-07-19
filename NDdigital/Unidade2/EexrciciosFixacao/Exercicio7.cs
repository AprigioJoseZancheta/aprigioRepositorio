using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* 7)	Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
       A fórmula de conversão é: F=(9*C+160) / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.*/
    class Exercicio7
    {
        static double celsius;
        static double converte;
        static void Main6()
        {
            Console.WriteLine("Informe a temperatura para conversão: ");
            celsius = double.Parse(Console.ReadLine());

            converte = ((9 * celsius + 160) / 5);

            Console.WriteLine("Temperatura convertida de graus Celsius para Fahrenheit: {0} ", converte);
            Console.ReadKey();
        }
    }
}
