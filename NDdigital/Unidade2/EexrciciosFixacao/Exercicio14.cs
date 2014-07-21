using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    class Exercicio14
    {
        /*14)	Escreva um algoritmo que envie uma mensagem como FALSO, caso o cálculo for VERDADEIRO e VERDADEIRO caso for falso. 
         * O programa ler 2 números e fazer todos os tipos de operadores lógicos já mostrados. Ex: 2 > 1 = FALSO */
        static void Main14()
        {
            int num1 = 0;
            int num2 = 0;
            bool opcao1;
            bool opcao2;
            bool opcao3;
            bool opcao4;
            bool opcao5;
            bool opcao6;

            Console.WriteLine("Informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            opcao1 = num1 > num2;
            opcao2 = num1 < num2;
            opcao3 = num1 == num2;
            opcao4 = num1 != num2;
            opcao5 = num1 >= num2;
            opcao6 = num1 <= num2;

            Console.WriteLine(!opcao1);
            Console.WriteLine(!opcao2);
            Console.WriteLine(!opcao3);
            Console.WriteLine(!opcao4);
            Console.WriteLine(!opcao5);
            Console.WriteLine(!opcao6);
            Console.ReadKey();
        }
    }
}
