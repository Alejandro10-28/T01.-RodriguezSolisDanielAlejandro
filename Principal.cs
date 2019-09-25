using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Principal
    {
        //Se crea el metodo para la bienvenida.
        public void Welcome()
        {
            Console.WriteLine("Bienvenido a mi calculadora");
        }
        //Se crea el metodo salir para llamar cuando el usuario quiera cerrar el programa.
        public void Salir()
        {
            Environment.Exit(0);//Esta función se usa para el cierre del programa por elección
        }
        //Se crea el metodo menú para que el usuario pueda elegir entre las opciones
        public void Menu()
        {
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar:");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Salir");
            //Se crea una variable de tipo int para que el usuario elija una de las opciones que tiene en el menú.
            int O = Convert.ToInt32(Console.ReadLine());
            //Se instancia la clase operaciones para acceder a los metodos de ella dependiendo el switch.
            Operacion M = new Operacion();

            do//Se crea el ciclo do-while para que el usuario pueda seguir utilizando la calculadora mientras el lo desee
            {
                //Se crea la variable donde se guardaran los resultados
                double R = 0;
                //Se instancia la clase valores para poder acceder a los atributos donde el usuario llenara sus datos.
                Valores Resultado1 = new Valores();

                switch (O)//Utilice un switch para que el usuario pueda elegir entre las opciones del menú
                {

                    case 1:
                        //Se pide que el usuario ingrese los valores con los que realizara la operación
                        Console.WriteLine("Ingresa dos valores:");
                        Console.WriteLine("Ingresa valor A:");
                        Resultado1.valorA = Convert.ToDouble(Console.ReadLine());//Se usa para que el usuario ingrese cualquier dato de tipo double
                        Console.WriteLine("Ingresa valor B:");
                        Resultado1.valorB = Convert.ToDouble(Console.ReadLine());

                        R = M.Sumar(Resultado1);//Se manda como parametro Resultado1 el cual contiene los datos que ingreso el usuario.
                        //Cabe destacar que se utiliza M ya que esta contiene los metodos de la clase operación que se usaran dependiendo la
                        //Elección del usuario.
                        Console.Clear();//Utilizas Console.Clear() para limpiar los residuos y no se acumulen en cada repetición
                        break;
                    case 2:
                        Console.WriteLine("Ingresa dos valores:");
                        Console.WriteLine("Ingresa valor A:");
                        Resultado1.valorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor B:");
                        Resultado1.valorB = Convert.ToDouble(Console.ReadLine());

                        R = M.Restar(Resultado1);
                        Console.Clear();

                        break;
                    case 3:
                        Console.WriteLine("Ingresa dos valores:");
                        Console.WriteLine("Ingresa valor A:");
                        Resultado1.valorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor B:");
                        Resultado1.valorB = Convert.ToDouble(Console.ReadLine());
                        R = M.Multiplicar(Resultado1);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Ingresa dos valores:");
                        Console.WriteLine("Ingresa valor A:");
                        Resultado1.valorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor B:");
                        Resultado1.valorB = Convert.ToDouble(Console.ReadLine());
                        R = M.Dividir(Resultado1);
                        Console.Clear();
                        break;
                    case 5:
                        Salir();//Se llama a la función salir() la cual se encuentra dentro de esta clase para dar cierre al programa.
                        break;
                    default:
                        Console.WriteLine("Valor no encontrado");//En default deje la posibilidad de que el usuario no ingrese alguna de las opciones
                        // del menú para que asi le mande un mensaje donde le diga que no se encuentra el valor que el ingreso si gusta "realizar otra operación"
                        //asi sin cerrar el programa ya que el usuario podria haberse equivocado pero sin querer salir del programa
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                Console.WriteLine("¿Desea realizar otra operación?");
                Menu();
            } while (O !=5);//Mientras la opción sea distinta a la opción salir la cual es la 5, este ciclo se seguira repitiendo.

        }

      
    }
}
