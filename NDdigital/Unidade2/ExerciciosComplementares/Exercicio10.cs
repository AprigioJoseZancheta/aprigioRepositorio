using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*10)	Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres (considere que as idades dos homens serão sempre diferentes entre si, bem como as das mulheres). 
     * Calcule e escreva a soma das idades do homem mais velho com a mulher mais nova, e o produto das idades do homem mais novo com a mulher mais velha. */
    class Exercicio10
    {
        static void Main10()
        {
            int idadeHomem1 = 0;
            int idadeHomem2 = 0;
            int idadeMulher1 = 0;
            int idadeMulher2 = 0;
            double somaIdade = 0;
            double produtoIdade = 0;

            Console.WriteLine("Digite a idade do primeiro homem: ");
            idadeHomem1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do segundo homem: ");
            idadeHomem2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da primeira mulher: ");
            idadeMulher1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da segunda mulher: ");
            idadeMulher2 = int.Parse(Console.ReadLine());

            if ((idadeHomem1 > idadeHomem2) && (idadeMulher1 < idadeMulher2))
            {
                somaIdade = idadeHomem1 + idadeMulher1;
                produtoIdade = idadeMulher2 * idadeHomem2;
                Console.WriteLine("Soma idade homem mais velho com mulher mais nova {0} ", somaIdade);
                Console.WriteLine("Produto idade da mulher mais velha com homem mais novo {0} ", produtoIdade );
            }
            else if ((idadeHomem1 > idadeHomem2) && (idadeMulher1 > idadeMulher2))
            {
                somaIdade = idadeHomem1 + idadeMulher1;
                produtoIdade = idadeMulher2 * idadeHomem2;
                Console.WriteLine("Soma idade homem mais velho com mulher mais nova {0} ", somaIdade);
                Console.WriteLine("Produto idade da mulher mais velha com homem mais novo {0} ", produtoIdade);
            }
            else if ((idadeHomem2 > idadeHomem1) && (idadeMulher2 < idadeMulher1))
            {
                somaIdade = idadeHomem2 + idadeMulher2;
                produtoIdade = idadeMulher1 * idadeHomem1;
                Console.WriteLine("Soma idade homem mais velho com mulher mais nova {0} ", somaIdade);
                Console.WriteLine("Produto idade da mulher mais velha com homem mais novo {0} ", produtoIdade);
            }
            else if ((idadeHomem2 > idadeHomem1) && (idadeMulher2 > idadeMulher1))
            {
                somaIdade = idadeHomem2 + idadeMulher2;
                produtoIdade = idadeMulher1 * idadeHomem1;
                Console.WriteLine("Soma idade homem mais velho com mulher mais nova {0} ", somaIdade);
                Console.WriteLine("Produto idade da mulher mais velha com homem mais novo {0} ", produtoIdade);
            }
            
            Console.ReadKey();
        }
    }
}
