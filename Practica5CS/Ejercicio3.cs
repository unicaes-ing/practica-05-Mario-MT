using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class Ejercicio3
    {
        static int Fact(int valor)
        {
            int fact = valor;
            for (int i = 1; i < valor; i++)
            {
                fact = fact * (valor - i);
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine("Ingrese un número entero:");
                int.TryParse(Console.ReadLine(), out num);
            } while (num <= 0);

            Console.WriteLine("El factorial del numero {0:N2} es {1:N2}", num, Fact(num));
            Console.ReadKey();
        }
    }
}
