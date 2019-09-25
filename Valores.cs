using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Valores
    {
        //Se crean los atributos de los valores que se ingresaran para realizar las operaciones.
        private double ValorA;
        private double ValorB;
        //Se crean las encapsulaciones 
        public double valorA
        {
            get { return ValorA; }
            set { ValorA = value; }
        }
        public double valorB
        {
            get { return ValorB; }
            set { ValorB = value; }
        }
   
    }
}
