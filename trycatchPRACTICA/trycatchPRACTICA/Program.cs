using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchPRACTICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            try
            {
                Console.Write("Ingresar un número: ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("El cuadrado del número es: " + Math.Pow(num, 2));
                Console.ReadKey();
            }
            catch(FormatException m)
            {
                Console.WriteLine("Error: " + m.Message);
            }
            catch (OverflowException m)
            {
                Console.WriteLine("Error: " + m.Message);
            }

            Console.ReadKey();
        }
    }
}
