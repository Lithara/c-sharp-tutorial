﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}
