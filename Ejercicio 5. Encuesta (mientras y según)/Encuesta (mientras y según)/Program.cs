using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta__mientras_y_según_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorEncuestado, Opinion, Opinion1, Opinion2, Opinion3;
            Opinion1 = 0;
            Opinion2 = 0;
            Opinion3 = 0;
            contadorEncuestado = 0;
            Console.WriteLine("Ingrese por positivo (0), negativo (1), e indeciso (2)");
            Opinion = Convert.ToInt32(Console.ReadLine());
            while (Opinion >= 0 && Opinion <= 2)
            {
                switch (Opinion)
                {
                    case 0:
                        Opinion1++;
                        break;
                    case 1:
                        Opinion2++;
                        break;
                    case 2:
                        Opinion3++;
                        break;
                }
                contadorEncuestado++;
                Console.WriteLine("Ingrese por positivo (0), negativo (1), e indeciso (2)");
                Opinion = Convert.ToInt32(Console.ReadLine());
            }
            if (contadorEncuestado > 0)
            {
                Console.WriteLine("El total de opiniones ingresadas es: " + contadorEncuestado);
                Console.WriteLine("El porcentaje de opiniones positivas es: " + (Opinion1 * 100 / contadorEncuestado) + "%");
                Console.WriteLine("El porcentaje de opiniones negativas es: " + (Opinion2 * 100 / contadorEncuestado) + "%");
                Console.WriteLine("El porcentaje de opiniones indecisas es: " + (Opinion3 * 100 / contadorEncuestado) + "%");
            }
            else
            {
                Console.WriteLine("No se ingresaron opiniones válidas.");
            }

        }
    }
}
