using System;
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
            Student objStudent = new Student();

            objStudent.MyFunction();
            objStudent.MyInfo();

            Console.WriteLine(objStudent.Sum);

            Console.ReadKey();
        }
    }
}
