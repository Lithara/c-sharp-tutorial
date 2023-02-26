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
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Lithara";
            human1.age = 20;

            human2.name = "Dihansa";
            human2.age = 21;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();




            Console.ReadKey();
        }
    }
    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
