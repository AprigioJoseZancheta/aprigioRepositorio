using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.EexrciciosFixacao
{
    /* 12)	O custo ao consumidor de um carro novo é a soma do custo de fábrica com a percentagem do distribuidor e dos impostos 
     * (aplicados, primeiro os impostos sobre o custo de fábrica, e depois a percentagem do distribuidor sobre o resultado). 
     * Supondo que a percentagem do distribuidor seja de 28% e os impostos 45%. Escrever um algoritmo que leia o custo de fábrica de um carro e informe 
     * o custo ao consumidor do mesmo. 
     * */
    class Exercicio12
    {
        static void Main12()
        {
            try
            {
                Console.WriteLine("Informe o custo de fabrica do automóvel: ");
                double custoFabrica = double.Parse(Console.ReadLine());

                double percentagemDistribuidor = (custoFabrica * 28) / 100;
                double impostos = (custoFabrica * 45) / 100;
                double custoConsumidor = custoFabrica + impostos + percentagemDistribuidor;

                Console.WriteLine("Custo de Fabrica {0} ", custoFabrica);
                Console.WriteLine("Impostos {0} ", impostos);
                Console.WriteLine("Percentagem Distribuidor {0} ", percentagemDistribuidor);
                Console.WriteLine("Custo ao consumidor {0} ", custoConsumidor);
            }
            catch (Exception)
            {
                Console.WriteLine("Digite somente núumero");
            }
            Console.ReadKey();
        }
    }
}
