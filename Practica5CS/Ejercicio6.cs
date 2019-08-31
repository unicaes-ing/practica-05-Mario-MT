using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5CS
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int c;
            bool rep = false;
            decimal suma = 0;
            Console.WriteLine("¿Cuantos estudiantes se sometieron a la prueba?");
            do
            {
                if (int.TryParse(Console.ReadLine(), out c) && c >= 0)
                {
                    decimal[] notas = new decimal[c];
                    rep = false;
                    for (int i = 0; i <= c - 1; i++)
                    {
                        Console.WriteLine("Ingrese la nota del alumno N°" + (i + 1));
                        do
                        {
                            if (decimal.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 10)
                            {

                                suma = suma + notas[i];
                                rep = false;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                rep = true;
                            }
                        } while (rep == true);

                    }
                }
                else
                {
                    Console.WriteLine("El valor debe de ser positivo");
                    rep = true;
                }
            } while (rep == true);
            Console.WriteLine("La nota promedio es: {0:N2}", promedio(suma, c));
            Console.ReadKey();
        }

        static decimal promedio(decimal s, int c)
        {
            decimal prom = s / c;
            return prom;
        }
    }
}
