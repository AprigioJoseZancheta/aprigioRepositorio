using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    // 3)	Escrever um algoritmo para determinar o consumo médio de um automóvel sendo fornecida a distância total percorrida pelo automóvel e o total de combustível gasto.
    class Exercicio3
    {
        static double quantidadeLitros;
        static int distanciaPercorrida;
        static double consumoMedio;
        static void Main2(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida: ");
            distanciaPercorrida = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de litros gastos: ");
            quantidadeLitros = double.Parse(Console.ReadLine());

            ConsumoMedio(distanciaPercorrida, quantidadeLitros);
        }

        static void ConsumoMedio(int distanciaPercorrida, double quantidadeLitros)
        {
            Console.WriteLine("Consumo Medio {0} {1} ", consumoMedio = distanciaPercorrida / quantidadeLitros, "Litros");
            Console.ReadKey();
        }
    }
}
