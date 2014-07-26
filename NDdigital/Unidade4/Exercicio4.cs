using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*Serie Fibonacci*/
    class Exercicio4
    {
        static void Main4()
        {
            int novoNumero = 0;
            int numeroAtual = 1;
            int numeroAnteriror = 0;

            for (int i = 0; i < 3; i++)
            {
                novoNumero = numeroAnteriror + numeroAtual;
                numeroAnteriror = numeroAtual;
                numeroAtual = novoNumero;
                Console.WriteLine("O na posição " +i+ " número de fibonacci " + numeroAtual);
            }
            Console.ReadKey();
        }
    }
}
