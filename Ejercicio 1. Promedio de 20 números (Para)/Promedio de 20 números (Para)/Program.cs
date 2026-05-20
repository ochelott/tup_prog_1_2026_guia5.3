using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_20_números__Para_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contador, acumulador, i;
            double promedio;
            acumulador = 0;
            contador = 0;
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());
               acumulador = acumulador + num;
                contador = contador + 1;
            }
            promedio = (Double)acumulador / contador;
            Console.WriteLine($"El promedio de los 20 números es: {promedio:F2}");
        }
    }
}
