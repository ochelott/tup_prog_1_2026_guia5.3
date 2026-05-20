using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubros__mientras_y_según_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Rubro1, Rubro2, Rubro3, Rubro4, Rubro5, Rubros, venta, cantProdVendidos;
            int NumeroVentaMayor = 0, totalProductos = 0;
            double precio, total, RecaudacionTot, MayorMontoTot;

            total = 0;
            Rubro1 = 0;
            Rubro2 = 0;
            Rubro3 = 0;
            Rubro4 = 0;
            Rubro5 = 0;
            venta = 0;
            Rubros = 1;
            RecaudacionTot = 0;
            MayorMontoTot = 0;
            Console.WriteLine("Ingrese el rubro del producto del vendido (1-5):");
            Rubros = Convert.ToInt32(Console.ReadLine());

            while (Rubros != -1)
            {
                
                Console.WriteLine("Ingrese cantidad de productos vendidos:");
                cantProdVendidos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del producto vendido:");
                precio = Convert.ToDouble(Console.ReadLine());
                switch (Rubros)
                {
                    case 1:
                        Rubro1 += cantProdVendidos;
                        total = (double)precio * cantProdVendidos;
                        totalProductos += cantProdVendidos;
                        break;
                    case 2:
                        Rubro2 += cantProdVendidos;
                        total = (double)precio * cantProdVendidos;
                        totalProductos += cantProdVendidos;
                        break;
                    case 3:
                        Rubro3 += cantProdVendidos;
                        total = (double)precio * cantProdVendidos;
                        totalProductos += cantProdVendidos;
                        break;
                    case 4:
                        total = (double)precio * cantProdVendidos;
                        Rubro4 += cantProdVendidos;
                        totalProductos += cantProdVendidos;
                        break;
                    case 5:
                        total = (double)precio * cantProdVendidos;
                        Rubro5 += cantProdVendidos;
                        totalProductos += cantProdVendidos;
                        break;
                    default:
                        Console.WriteLine("Rubro no válido. Intente nuevamente.");
                        break;
                }
                venta = venta + 1;
                RecaudacionTot = RecaudacionTot + total;
                if (total > MayorMontoTot)
                {
                    MayorMontoTot = total;
                    NumeroVentaMayor = venta;
                }

                Console.WriteLine("Ingrese el rubro del producto vendido (1-5) o (-1) para finalizar:");
                Rubros = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Cantidad de productos vendidos por cada rubro:");
                Console.WriteLine($"Rubro 1: {Rubro1 * 100.0 / totalProductos:F2}%");
                Console.WriteLine($"Rubro 2: {Rubro2 * 100.0 / totalProductos:F2}%");
                Console.WriteLine($"Rubro 3: {Rubro3 * 100.0 / totalProductos:F2}%");
                Console.WriteLine($"Rubro 4: {Rubro4 * 100.0 / totalProductos:F2}%");
                Console.WriteLine($"Rubro 5: {Rubro5 * 100.0 / totalProductos:F2}%");
                
                Console.WriteLine($"Número de venta con mayor monto total: {NumeroVentaMayor}");
                Console.WriteLine($"Recaudación total: $ {RecaudacionTot:F2}");
        }
    }
}
