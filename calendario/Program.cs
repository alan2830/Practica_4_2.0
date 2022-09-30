using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte calendario;

            Console.WriteLine("Dime un numero del 1 al 12 y le dire a que mes corresponde");
            calendario = Convert.ToByte(Console.ReadLine()); 

            switch(calendario)
            {
                case 1:
                    Console.WriteLine("este numero corresponde al mes de enero");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("este numero corresponde al mes de febrero");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("este numero corresponde al mes de marzo");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("este numero corresponde al mes de abril");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("este numero corresponde al mes de mayo");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("este numero corresponde al mes de junio");
                    Console.ReadLine();
                    break;

                case 7:
                    Console.WriteLine("este numero corresponde al mes de julio");
                    Console.ReadLine();
                    break;

                case 8:
                    Console.WriteLine("este numero corresponde al mes de agosto");
                    Console.ReadLine();
                    break;

                case 9:
                    Console.WriteLine("este numero corresponde al mes de septiembre");
                    Console.ReadLine();
                    break;

                case 10:
                    Console.WriteLine("este numero corresponde al mes de octubre");
                    Console.ReadLine();
                    break;

                case 11:
                    Console.WriteLine("este numero corresponde al mes de noviembre");
                    Console.ReadLine();
                    break;

                case 12:
                    Console.WriteLine("este numero corresponde al mes de diciembre");
                    Console.ReadLine();
                    break;

                    default: Console.WriteLine("opcion no existente, vuelva a intentar con una de las opciones disponibles");
                    Console.ReadLine();
                    break ;


            }


        }
    }
}
