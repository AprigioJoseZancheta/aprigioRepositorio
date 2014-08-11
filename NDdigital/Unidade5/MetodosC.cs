using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade5
{
    class MetodosC
    {
         public double valor1;
         public double valor2;
         public double soma;

        public  void Somar()
        {
            soma = valor1 + valor2;
        }
        public void Somar(double vl1, double vl2)
        {
            soma = valor1 + valor2;
        }
        public double SomarParametros(double vl1, double vl2)
        {
            return vl1 + vl2;
        }
    }
}
