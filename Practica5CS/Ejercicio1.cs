using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class Ejercicio1
    {
        static DateTime dia(DateTime today)
        {
            DateTime hoy = today;
            DateTime final = new DateTime(2019, 12, 31);
            TimeSpan ts = final - hoy;
            int diasr = ts.Days;
            Console.WriteLine("Del dia {0} hasta el dia {1}", hoy.ToString("D"), final.ToString("D"));
            Console.WriteLine("faltan {0} dias para que termine el año", diasr);
            return hoy;
        }
        static void Main(string[] args)
        {
                DateTime hoy = DateTime.Today;
                dia(hoy);
                Console.ReadKey();
        }
    }
}
