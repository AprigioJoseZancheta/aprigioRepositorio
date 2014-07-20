using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*1)	Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor. */
    class Exercicio1
    {
        static void Main1()
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                numero = numero - 1;
                Console.WriteLine("Número antecessor: {0} ", numero);
            }
            catch (Exception)
            {

                Console.WriteLine("Somente Números");
            }
            Console.ReadKey();
        }
       
    }
}
