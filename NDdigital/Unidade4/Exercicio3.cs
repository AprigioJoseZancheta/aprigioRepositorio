using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    /*2) Se o Número e primo ou não*/
    class Exercicio3
    {
        static void Main3()
        {
            int i = 2;
            int cont = 0;
            int numero = 0;

            Console.WriteLine("Digite um número para saber se ele e primo: ");
            numero = int.Parse(Console.ReadLine());

            while (i < numero)
            {
                if (numero % i == 0)
                {
                    cont++; 
                }
                i++;
            }
            if (cont > 0)
            {
                Console.WriteLine("Não é primo");
            }
            else
            {
                Console.WriteLine("É primo");
            }
           
            Console.ReadKey();
        }
    }
}
