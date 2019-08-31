using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class Ejercicio4
    {
        static string ganador (string num1, string num2, string num3, string num4)
        {
            int aleatorio;
            Random rnd = new Random();
            aleatorio = rnd.Next(1, 5);
            switch (aleatorio)
            {
                case 1:
                    return num1;
                case 2:
                    return num2;
                case 3:
                    return num3;
                case 4:
                    return num4;
                default:
                    break;
            }
            return ""; 
        }
        static void Main(string[] args)
        {
            string n1, n2, n3, n4;
            Console.WriteLine("Introduzca los números de telefono");
            n1 = Console.ReadLine();
            n2 = Console.ReadLine();
            n3 = Console.ReadLine();
            n4 = Console.ReadLine();
            Console.WriteLine("El ganador es: "+ ganador (n1, n2, n3, n4));
            Console.ReadKey();
        }
    }
}
