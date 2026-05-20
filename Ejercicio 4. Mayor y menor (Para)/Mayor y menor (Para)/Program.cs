using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_y_menor__Para_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor, menor, i;
            mayor = 0;
            menor = 0;
            for ( i = 1; i < 30; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                if (num > mayor)
                {
                    mayor = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);

            Console.ReadKey();
        }
    }
}
