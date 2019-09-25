using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        double resultado;
        //Se crearan los metodos donde se realizaran las operaciones
            public double Sumar(Valores suma)//Se crea un parametro con el tipo de dato valores para utilizar los atributos de la clase.
            {
                //Se crea la variable resultado donde guardara la operación que se realizara
                resultado = suma.valorA + suma.valorB;
                Console.WriteLine("El resultado es: {0}", resultado);
                Console.ReadKey();
                
                return resultado;//Se retorna el valor de la variable resultado
            }
            
            public double Restar(Valores Restar)
            {

                resultado = Restar.valorA - Restar.valorB;
                Console.WriteLine("El resultado es:{0}",resultado);
                Console.ReadKey();
                return resultado;
            }
        public double Dividir(Valores Dividir)
        {

             resultado = Dividir.valorA / Dividir.valorB;
            Console.WriteLine("El resultado es:{0}", resultado);
            Console.ReadKey();
                return resultado;
        }
            public double Multiplicar(Valores Multiplicar)
            {


                resultado = Multiplicar.valorA * Multiplicar.valorB;
                Console.WriteLine("El resultado es:{0}" , resultado);
                Console.ReadKey();
                return resultado;
            }
        
    }     
}
