using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*2)	Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo. */
    class Exercicio2
    {
        static void Main2()
        {
            try
            {
                Console.WriteLine("Informe a base do retângulo");
                double baseRetangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a altura do retângulo");
                double alturaRetangulo = double.Parse(Console.ReadLine());
                double calculaAreaRetangulo = baseRetangulo * alturaRetangulo;
                Console.WriteLine("Calculo da Area do Retângulo {0} ", calculaAreaRetangulo);
            }
            catch (Exception)
            {

                Console.WriteLine("Somente Números");
            }
            Console.ReadKey();
        }
    }
}
