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
            String firstName = "Lithara";
            String lastName = "Perera";

            int age = 20;

            Console.WriteLine("Hello! " + firstName + " " + lastName + ".");
            Console.WriteLine($"Hello! {firstName} {lastName}.");
            Console.WriteLine($"You're {age,-10} old.");

            Console.ReadKey();
        }
    }
}
