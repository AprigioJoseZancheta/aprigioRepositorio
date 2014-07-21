using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3
{
    /*5)  Ler  80  números  e  ao  final  informar  quantos  número(s)  est(á)ão  no  intervalo  entre  10 
     (inclusive) e 150 (inclusive). */
    class Exercicio5
    {
        static void Main5()
        {
            Random gerar = new Random();
            int[] numero = new int[80];
            int contNumero = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = gerar.Next(400);
            }
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] >= 10 && numero[i] <= 150)
                {
                    contNumero++;
                    Console.WriteLine("Numeros: {0} ", numero[i]);
                    
                }
            }
            Console.WriteLine("Quantos número estão estre 10 e 150: {0} ", contNumero);
            Console.ReadKey();
        }
    }
}
