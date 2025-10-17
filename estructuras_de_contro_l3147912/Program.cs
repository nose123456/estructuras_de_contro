using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Program
    {
        private const float V = 0.2f;

        static void Main(string[] args)// punto de partida
        {
            //tipos de datos


            //estructura de control
            //Console.WriteLine("Ingrese su edad: .");
            //int numero = int.Parse(Console.ReadLine()); //para leer la entrda de datos

            //Console.WriteLine($"su edad es: "+numero);
            //Console.WriteLine($"su edad es:  {numero}");


            //Console.WriteLine("ingrese 3 notas");
            //float n1 = int.Parse(Console.ReadLine());
            //float n2 = int.Parse(Console.ReadLine());
            //float n3 = int.Parse(Console.ReadLine());
            //if (n1 < 0 | n1 >5 | n2 < 0 | n2 > 5 | n3 < 0 | n3 > 5) ;
            //float promedioes = (n1 * 0.2f) + (n2 * 0.3f) + (n3 * 0.5f);
            //if(promedioes>=3)
            //{
            //    Console.WriteLine("aprobado");
            //}
            //else
            //{
            //    Console.WriteLine("desaprobado");
            //}

            //Console.WriteLine("Ingrese el precio del producto:");
            //float product = float.Parse(Console.ReadLine());

            //if (product >= 100000)
            //{
            //    float discount = product * 0.20f; // 20% de descuento
            //    float finalPrice = product - discount;
            //    Console.WriteLine($"Se le aplica un 20% de descuento, el precio final es: {finalPrice}");
            //}
            //else
            //{
            //    Console.WriteLine($"No se aplica descuento, el precio es: {product}");
            //}

            Console.WriteLine("=== COLILLA DE PAGO ===\n");

            // Entradas
            Console.Write("Ingrese el salario del empleado: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de ahorro mensual programado: ");
            double ahorro = Convert.ToDouble(Console.ReadLine());

            // Cálculos
            double eps = salario * 0.125;
            double pension = salario * 0.16;
            double totalDeducciones = eps + pension + ahorro;
            double totalRecibir = salario - totalDeducciones;

            // Salida
            Console.WriteLine("\n RESULTADOS ");
            Console.WriteLine($"Salario del Empleado: ${salario:N2}");
            Console.WriteLine($"Ahorro Mensual Programado: ${ahorro:N2}");
            Console.WriteLine($"Deducción EPS (12.5%): ${eps:N2}");
            Console.WriteLine($"Deducción Pensión (16%): ${pension:N2}");
            Console.WriteLine($"Total a Recibir: ${totalRecibir:N2}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();


        }
    }
}
