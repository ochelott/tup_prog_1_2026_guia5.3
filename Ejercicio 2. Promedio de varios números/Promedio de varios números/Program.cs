using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_varios_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contador, acumulador;
            double promedio;
            contador = 0;
            acumulador = 0;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            while (num != -1) 
            {
                contador++;
                acumulador += num;
                Console.WriteLine("Ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if  (acumulador != 0)
            {
                promedio = (double)acumulador / contador;
                Console.WriteLine($"El promedio es: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }
        }
    }
}
