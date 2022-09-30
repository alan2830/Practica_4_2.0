using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiempo;

            Console.WriteLine("Estacionamiento: cuanto tiempo estuvo estacionado?");
            tiempo = Convert.ToInt32(Console.ReadLine());

            if (tiempo <= 60)
            {
                Console.WriteLine("son 5 pesos");
                Console.ReadLine();
            }

            if (tiempo >= 61 && tiempo <= 120)
            {
                Console.WriteLine("son 15 pesos");
                Console.ReadLine();
            }
            
            if (tiempo >=121)
            {
                Console.WriteLine("son 40 pesos");
                Console.ReadLine();

            }

        }
    }
}
