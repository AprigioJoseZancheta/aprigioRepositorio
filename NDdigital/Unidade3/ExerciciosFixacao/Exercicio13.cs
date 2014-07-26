using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*14) Escrever um algoritmo que lê um conjunto de 4 valores i, a, b, c, onde i é um valor inteiro 
    e positivo e a, b, c, são quaisquer valores reais e os escreva. A seguir: 
    a) Se i=1 escrever os três valores a, b, c em ordem crescente. 
    b) Se i=2 escrever os três valores a, b, c em ordem decrescente. 
    c) Se i=3 escrever os três valores a, b, c de forma que o maior entre a, b, c fique dentre os 
    dois.*/
    class Exercicio13
    {
        static void Main13()
        {
            int i = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número pra i \n(1 pra ordem decrescente)\n(2 pra ordem crescente)\n(3 pra o maior valor ficar no meio)");
            i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1: if ((a > b) && (a > c) && (b > c))
                        {
                            Console.WriteLine("A" + a + " " + "B" + b + " " + "C" + c);
                        }
                        else if ((a > b) && (a > c) && (c > b))
                        {
                            Console.WriteLine("A" + a + " " + "C" + c + " " + "B" + b);
                        }
                        if ((b > a) && (b > c) && (a > c))
                        {
                            Console.WriteLine("B" + b + " " + "A" + a + " " + "C" + c);
                        }
                        else if ((b > a) && (b > c) && (c > a))
                        {
                            Console.WriteLine("B" + b + " " + "C" + c + " " + "A" + a);
                        }
                        if ((c > a) && (c > b) && (a > b))
                        {
                            Console.WriteLine("C" + c + " " + "A" + a + " " + "B" + b);
                        }
                        else if ((c > a) && (c > b) && (b > a))
                        {
                            Console.WriteLine("C" + c + " " + "B" + b + " " + "A" + a);
                        }
                       break;
                case 2: if ((a < b) && (a < c) && (b < c))
                       {
                           Console.WriteLine("A" + a + " " + "B" + b + " " + "C" + c);
                       }
                       else if ((a < b) && (a < c) && (c < b))
                       {
                           Console.WriteLine("A" + a + " " + "C" + c + " " + "B" + b);
                       }
                       if ((b < a) && (b < c) && (a < c))
                       {
                           Console.WriteLine("B" + b + " " + "A" + a + " " + "C" + c);
                       }
                       else if ((b < a) && (b < c) && (c < a))
                       {
                           Console.WriteLine("B" + b + " " + "C" + c + " " + "A" + a);
                       }
                       if ((c < a) && (c < b) && (a < b))
                       {
                           Console.WriteLine("C" + c + " " + "A" + a + " " + "B" + b);
                       }
                       else if ((c < a) && (c < b) && (b < a))
                       {
                           Console.WriteLine("C" + c + " " + "B" + b + " " + "A" + a);
                       }
                       break;
                case 3: if ((a > b) && (a > c) && (b > c))
                       {
                           Console.WriteLine("B" + b + " " + "A" + a + " " + "C" + c);
                       }
                       else if ((a > b) && (a > c) && (c > b))
                       {
                           Console.WriteLine("C" + c + " " + "A" + a + " " + "B" + b);
                       }
                       if ((b > a) && (b > c) && (a > c))
                       {
                           Console.WriteLine("A" + a + " " + "B" + b + " " + "C" + c);
                       }
                       else if ((b > a) && (b > c) && (c > a))
                       {
                          Console.WriteLine("C" + c + " " + "B" + b + " " + "A" + a); 
                       }
                       if ((c > a) && (c > b) && (a > b))
                       {
                           Console.WriteLine("A" + a + " " + "C" + c + " " + "B" + b);
                       }
                       else if ((c > a) && (c > b) && (b > a))
                       {
                           Console.WriteLine("B" + b + " " + "C" + c + " " + "A" + a);
                       }
                       break;
                default: Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
