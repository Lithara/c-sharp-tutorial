using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1 : ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2 : ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result : " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thank you for visiting!");
            }
            Console.ReadKey();
        }
    }
}
