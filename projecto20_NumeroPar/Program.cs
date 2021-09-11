using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto20_NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que que me indique si un numero es par o impar, 
            //que muestre un  mensaje de salida

            int numero;
            Console.WriteLine("Ingrese el Numero ? ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 ==0)
            {
                Console.WriteLine("el numero es Par ");
            }
            else
            {
                Console.WriteLine("El numero es impar ");
            }
            Console.ReadLine();

        }
    }
}
