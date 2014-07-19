using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* 6)	Ler dois valores para as variáveis A e B, e efetuar as trocas dos valores de forma que a variável 
       A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados*/
    class Exercicio6
    {
        static int A;
        static int B;
        static int aux;
        static void Main5()
        {
            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            trocaValores(A, B);
        }

        static void trocaValores(int A, int B)
        {
            aux = A;
            A = B;
            B = aux;

            Console.WriteLine("Valor A: {0}, Valor B: {1} ", A, B + " Valores trocados");
            Console.ReadKey();
        }
    }
}
