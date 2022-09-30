using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_par_o_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte digito;

            Console.WriteLine("ingresa un digito y te dire si es par o impar");
            digito = Convert.ToByte (Console.ReadLine());   

            if(digito %2 == 0)
            {
                Console.WriteLine("el digito ingresado es par");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("el digito ingresado es impar");
                Console.ReadLine();
            }
        }
    }
}
