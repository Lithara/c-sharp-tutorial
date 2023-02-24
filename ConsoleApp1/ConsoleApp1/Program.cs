using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Enter a number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
}
