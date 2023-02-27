using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak;
            cat.Speak;

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}
