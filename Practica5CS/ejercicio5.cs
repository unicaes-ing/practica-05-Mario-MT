using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class ejercicio5
    {
        static double Precio(double monto, double descuento)
        {
            double total = 0;
            descuento = descuento * 0.010;
            if (descuento != 0)
            {
                total = monto + (monto * descuento);
                return total;
            }
            else
            {
                return monto;
            }

        }
        static void Main(string[] args)
        {
            double precio = 0, porcent = 0;
            do
            {
                Console.WriteLine("¿Cúal es el precio del producto?");
                Double.TryParse(Console.ReadLine(), out precio);
            } while (precio <= 0);

            do
            {
                Console.WriteLine("¿Cual es el porcentaje de descuento?");
                Double.TryParse(Console.ReadLine(), out porcent);
            } while (porcent < 0 || porcent > 100);

            Console.WriteLine("El valor de descuento es: {0:P}", porcent / 100);
            Console.WriteLine("se le pagara: {0:C2}", Precio(precio, porcent));
            Console.ReadKey();
        }
    }
}
