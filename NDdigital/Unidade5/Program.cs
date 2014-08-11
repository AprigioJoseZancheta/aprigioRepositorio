using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosC metodo = new MetodosC();

            calculaValores(metodo);

            somaValores(metodo);
            Console.WriteLine("Somar {0} ", metodo.soma);

            
            Console.WriteLine("Metodos Parametros {0} ", metodo.soma);

            Console.WriteLine("Metodo com retorno {0} ", metodo.SomarParametros(4.3,5.6));
            Console.ReadKey();
        }
        static void calculaValores(MetodosC metodo)
        {
            metodo.valor1 = 4;
            metodo.valor2 = 7;
            metodo.soma = metodo.valor1 + metodo.valor2;
        }
        static void somaValores(MetodosC metodo)
        {
            metodo.soma = 5.5 + 7.7;
        }
    }
}
