using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Mayor__Mientras__centinela_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, menor, mayor, contador;
            mayor = 0;
            menor = 0;
            contador = 0;
            Console.WriteLine("Ingrese un numero (0 para terminar): ");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0 && numero < 100)
            {
                contador++;
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor || menor == 0)
                {
                    menor = numero;
                }
                Console.WriteLine("Ingrese un numero (0 para terminar): ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            if (contador > 0)
            {
                Console.WriteLine("El numero mayor es: " + mayor);
                Console.WriteLine("El numero menor es: " + menor);
            }
            else 
            { 
                Console.WriteLine("No se ingresaron numeros."); 
            }
            Console.ReadKey();
        }
    }
}
