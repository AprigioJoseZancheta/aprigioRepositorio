using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.ExerciciosComplementares
{
    /*6) A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra,
     * cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que leia o número de horas trabalhadas em um mês, 
     * o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas).  */
    class Exercicio6
    {
        static void Main()
        {
            int jornadaMes = 160;
            double horaExtra = 4.50;
            double horaRegular = 3;
            double salarioHora;
            try
            {
                Console.WriteLine("Informe quantas horas o funcionario trabalhou no mês: ");
                int horasTrabalhadasMes = int.Parse(Console.ReadLine());

                if (horasTrabalhadasMes <= jornadaMes)
                {
                    salarioHora = horaRegular * horasTrabalhadasMes;
                    Console.WriteLine("Salario por hora {0} ", salarioHora + " R$");
                }
                else if (horasTrabalhadasMes > jornadaMes)
                {
                    double quatidadeHorasExtraTrabalhada = horasTrabalhadasMes - jornadaMes;
                    double calculaHoraExtra = quatidadeHorasExtraTrabalhada * horaExtra;
                    double salarioTotal = (calculaHoraExtra * quatidadeHorasExtraTrabalhada);
                    Console.WriteLine("Salario Total {0} ", salarioTotal);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Somente Números");
            }
                Console.ReadKey();
        }
    }
}
