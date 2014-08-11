using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*3) Crie um algoritmo que receba o dia, mês e ano de uma data de nascimento (como parâmetros de entrada do método) e imprima a data por extenso no formato: 
     * dia de nome_mes de ano.*/
    class Exercicio10
    {
        static void Main10()
        {
            DateTime dataAgora = DateTime.Now;
            DateTime data = new DateTime(1981, 12, 19);
            Console.WriteLine(dataAgora);
            TimeSpan ts = dataAgora.Subtract(data);
            Console.WriteLine(data);
            Console.WriteLine(ts);
            Console.ReadKey();
        }
    }
}