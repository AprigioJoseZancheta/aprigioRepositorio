using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*12)  Faça um algoritmo que receba um número e mostre uma mensagem caso este número 
      sege maior que 80, menor que 25 ou igual a 40. */
    class Exercicio11
    {
        static void Main11()
        {
            int numero = 0;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 80 || numero < 25 || numero == 40)
            {
                Console.WriteLine("Número no intervalo");
            }
            else
            {
                Console.WriteLine("Número fora do intervalo");
            }
            Console.ReadKey();
        }
    }
}
