using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int Sm = 0;
            int Rt = 0;
            int Mt = 0;
            int Dv = 0; 
            int opcion = 0; 
            int opcion2 = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("");
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("");
                Console.WriteLine("1.- SUMAR");
                Console.WriteLine("2.- RESTAR");
                Console.WriteLine("3.- MULTIPLICAR");
                Console.WriteLine("4.- DIVIDIR");
                Console.WriteLine("5.- FINALIZAR");

                Console.WriteLine("Digite la opcion que desee");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer valor");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo valor");
                b = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Sm = a + b;
                    Console.WriteLine("El resultado de la suma es: " + Sm);
                }

                if (opcion == 2)
                {
                    Rt = a - b;
                    Console.WriteLine("El resultado de la resta es: " + Rt);
                }

                if (opcion == 3)
                {
                    Mt = a * b;
                    Console.WriteLine("El resultado de la multiplicacion es: " + Mt);
                }

                if (opcion == 4)
                {
                    Dv = a / b;
                    Console.WriteLine("El resultado de la division es: " + Dv);
                }

                if (opcion == 5)
                {
                    Environment.Exit(0); 
                }

                Console.WriteLine("¿Desea realizar otra operacion?");
                Console.WriteLine("1.- Si  2.-No");
                opcion2 = int.Parse(Console.ReadLine());

            } while (opcion2 == 1);

            Console.ReadLine(); 

        }
    }
}
