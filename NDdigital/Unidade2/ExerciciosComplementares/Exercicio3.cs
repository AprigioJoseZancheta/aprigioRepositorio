using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*3)	Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
     * meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. */
    class Exercicio3
    {
        static void Main3()
        {
            try
            {
                int anoAtual = 2014;
                Console.WriteLine("Informe o dia de seu nascimento: ");
                int dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o mês de seu nascimento: ");
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o ano de seu nascimento: ");
                int ano = int.Parse(Console.ReadLine());

                int calculaAno = anoAtual - ano;
                double calculaDiasVividos = (((mes * 30) + (calculaAno * 360)) + dia);

                Console.WriteLine("Quantos dias de vida: {0} ", calculaDiasVividos);
            }
            catch (Exception)
            {
                Console.WriteLine("Apenas Números");
            }
            Console.ReadKey();
        }
    }
}
