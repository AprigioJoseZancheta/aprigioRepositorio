using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2
{
    /*13)	Faça um algoritmo que imprima as seguintes junções (concatenação) de palavras ou caracteres e inteiros. 
     * “Curso ” + “NDDigital ” + “Beginner ” + 2014. São 4 variáveis, 3 de texto e uma numérica. */
    class Unidade_13
    {
        static void Main()
        {
            string curso = "Curso";
            string ndd = "NDDigital";
            string comeco = "Beginner";
            int ano = 2014;
            string concatenacao = curso + " " + ndd + " " + comeco + " " + ano;

            Console.WriteLine(concatenacao);
            Console.ReadKey();
        }
    }
}
