using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*13)  Faça um algoritmo que receba “N” números e mostre positivo, negativo ou zero para cada 
      número*/
    class Exercicio12
    {
        static void Main12()
        {
            Random gera = new Random();
            int[] numeros = new int[50];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gera.Next(-30, 30);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine("Positivos");
                }
                else if (numeros[i] < 0)
                {
                    Console.WriteLine("Negativo");
                }
                else if (numeros[i] == 0)
                {
                    Console.WriteLine("Zero");
                }
            }
            Console.ReadKey();
        }
    }
}
