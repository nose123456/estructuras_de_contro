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

            Console.WriteLine("Ingrese el precio del producto:");
            float product = float.Parse(Console.ReadLine());

            if (product >= 100000)
            {
                float discount = product * 0.20f; // 20% de descuento
                float finalPrice = product - discount;
                Console.WriteLine($"Se le aplica un 20% de descuento, el precio final es: {finalPrice}");
            }
            else
            {
                Console.WriteLine($"No se aplica descuento, el precio es: {product}");
            }


        }
    }
}
