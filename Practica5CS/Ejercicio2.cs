using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class Ejercicio2
    {
        static string PosNegCer(int num)
        {
            if (num < 0)
            {
                return "El número que usted ingresó es negativo";
            }
            else 
            if (num > 0)
            {
                return "El número que usted ingresó es positivo";
            }
            return "El número es 0";
        }
        static void Main(string[] args)
        {
            int num;
            bool condición;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un número entero");
                condición = int.TryParse(Console.ReadLine(), out num);
            } while (condición == false);
            Console.WriteLine(PosNegCer(num));
            Console.ReadKey();

        }
    }
}

