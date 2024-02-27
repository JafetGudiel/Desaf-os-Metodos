using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a calcular la suma de sus ingresos y promedio: ");
            Console.WriteLine("Ingrese su nombre porfavor: ");
            string nombreIngresado = Console.ReadLine();

            double sumaDeIngresos = SumaDeIngresos();
            double promedio = sumaDeIngresos / 3;

            Console.WriteLine("Hola {0}, en total ganaste {1} y el promedio es de: {2}", nombreIngresado,sumaDeIngresos,promedio);
            Console.ReadLine();
        }
        public static double SumaDeIngresos()
        {
            double suma = 0;
            Console.WriteLine("Ingrese sus ingresos del primer mes: ");
            suma += double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sus ingresos del segundo mes: ");
            suma += double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sus ingresos del tercer mes: ");
            suma += double.Parse(Console.ReadLine());

            return suma;
        }
    }
}
