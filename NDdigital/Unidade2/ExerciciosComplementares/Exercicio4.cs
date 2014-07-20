using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*4)	Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. 
     * Calcular e escrever o percentual que cada um representa em relação ao total de eleitores. */
    class Exercicio4
    {
        static void Main4()
        {
            double totalVotos = 0;
            double percentagemBrancos = 0;
            double percentagemNulos = 0;
            double percentagemValidos = 0;
            Console.WriteLine("Informe o número de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            totalVotos = votosBrancos + votosNulos + votosValidos;
            percentagemBrancos = ((votosBrancos / totalVotos)*100);
            percentagemNulos = ((votosNulos / totalVotos)*100);
            percentagemValidos = ((votosValidos / totalVotos)*100);
            Console.WriteLine("Quantidade votos brancos {0} ", votosBrancos);
            Console.WriteLine("Quantidade votos nulos {0} ", votosNulos);
            Console.WriteLine("Quantidade votos válidos {0} ", votosValidos);
            Console.WriteLine("Total de votantes {0} ", totalVotos);
            Console.WriteLine("Percentagem votos Brancos {0:F2} ", percentagemBrancos + "%");
            Console.WriteLine("Percentagem votos Nulos {0:F2} ", percentagemNulos + "%");
            Console.WriteLine("Percentagem votos Válidos {0:F2} ", percentagemValidos + "%");
            Console.ReadKey();
        }
    }
}
