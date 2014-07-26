using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade3.ExerciciosFixacao
{
    /*8)  A concessionária de veículos “CARANGO VELHO” está vendendo os seus veículos com 
    desconto. Faça um algoritmo que calcule e exiba o valor do desconto e o valor a ser pago 
    pelo  cliente  de  vários  carros.  O  desconto  deverá  ser  calculado  de  acordo  com  o  ano  do 
    veículo.  Até  2000  -  12%  e  acima  de  2000  -  7%.  O  sistema  deverá  perguntar  se  deseja 
    continuar calculando desconto até que a resposta seja: “(N) Não” Informar total de carros com 
    ano até 2000 e total geral. */
    class Exercicio8
    {
        static void Main8()
        {
            string calculaDesconto = "";
            int anoCarro = 0;
            int carroAte2000 = 0;
            int carroMais2000 = 0;
            int totalCarro = 0;
            double desconto = 0;

          
            do
            {
                Console.WriteLine("Informe o ano do carro: ");
                anoCarro = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja continuar calculando o  desconto (s) Sim ou (n) Não: ");
                calculaDesconto = Console.ReadLine();
                if (anoCarro <= 2000)
                {
                    desconto = desconto * 0.12;
                    carroAte2000++;
                }
                else
                {
                    desconto = desconto * 0.07;
                    carroMais2000++;
                }
            } while (calculaDesconto != "n");
            
            totalCarro = carroAte2000 + carroMais2000;
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Quantidade de carros até ano 2000: {0} ", carroAte2000);
            Console.WriteLine("Total Geral: {0} ", totalCarro);
            Console.ReadKey();

        }
    }
}
