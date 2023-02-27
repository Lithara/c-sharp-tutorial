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
            Car[] garage = { new Car("Mustang"), new Car("Corvett"), new Car("Lambo") };

            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
