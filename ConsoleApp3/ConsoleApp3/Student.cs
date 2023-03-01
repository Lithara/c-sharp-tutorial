using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public int Sum = 100;
        public String name = "Lithara";
        public double batch = 22.1;
        public String degree = "Software Engineering";

        public void MyFunction()
        {

        }

        public void MyInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Batch : " + batch);
            Console.WriteLine("Degree : " + degree);
        }
    }
}
