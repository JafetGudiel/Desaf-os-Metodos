using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = SumadeNumeros();
                Console.WriteLine("El resultado final de la suma es de: {0}", resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es numerico, Vuelva a intentarlo. ");
            }
            finally
            {
                Console.WriteLine("Programa Finalizado.");
            }

            Console.ReadLine(); 
        }

        static int SumadeNumeros()
        {
            Console.WriteLine("Programa De Suma De Numeros: ");
            Console.WriteLine("Ingrese el primer numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            return numero1 + numero2;
        }
    }
}
