using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    // 9)	Faça um algoritmo que receba um valor que foi depositado e exiba o valor com rendimento após um mês. Considere fixo o juro da poupança em 0,70% a. m.  
    class Exercicio9
    {
        static void Main8()
        {
            double juros = 1.70;
            double valorRendimento;
            try
            {
                Console.WriteLine("Digite o valor depositario: ");
                double valor = double.Parse(Console.ReadLine());

                valorRendimento = valor * juros;
                Console.WriteLine("Valor com o rendimento: {0} ", valorRendimento);
            }
            catch (Exception)
            {

                Console.WriteLine("Somente número");
            }
            Console.ReadKey();
        }
    }
}
