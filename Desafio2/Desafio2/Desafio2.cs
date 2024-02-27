using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta es una calculadora de operaciones matemamaticas basicas: ");
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int suma = Sumar(num1, num2);
            int resta = Restar(num1, num2);
            int multiplicacion = Multiplicar(num1, num2);
            int division = Dividir(num1, num2);

            Console.WriteLine("El resultado de la Suma es de: {0}", suma);
            Console.WriteLine("El resultado de la Resta es de: {0}", resta);
            Console.WriteLine("El resultado de la Multiplicacion es de: {0}", multiplicacion);
            Console.WriteLine("El resultado de la Division es de: {0}", division);

            Console.WriteLine("Gracias por utilizar nuestra calculadora");

            Console.ReadLine(); 
        }
        public static int Sumar(int sum1, int sum2)
        {
            return sum1 + sum2;
        }

        public static int Restar(int rest1, int rest2)
        {
            return rest1 - rest2;
        }

        public static int Multiplicar(int mult1, int mult2)
        {
            return mult1 * mult2;
        }

        public static int Dividir(int div1, int div2)
        {
            if (div2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0;
            }
            else
            {
                return div1 / div2;
            }
        }
    }
}
