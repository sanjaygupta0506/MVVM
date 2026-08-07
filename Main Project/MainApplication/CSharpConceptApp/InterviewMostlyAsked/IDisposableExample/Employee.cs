using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.InterviewMostlyAsked.IDisposableExample
{
    // Fix: Fully qualify IDisposable to avoid ambiguity with namespace
    public class Employee : IDisposable
    {
        private bool disposed = false;
        public Employee()
        {
            Console.WriteLine("Resource Allocated");
        }

        public void work()
        {
            Console.WriteLine("Employee is working");
        }
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Resource Released");
                disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        //public static void Main(string[] args)
        //{
        //    using(Employee emp  = new Employee())
        //    {
        //        emp.work();
        //    }

        //    using(FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate))
        //    {
        //        Console.WriteLine("FileStream is working");
        //    }
        //    Console.WriteLine("File closed automatically.");

        //    Console.ReadLine();
        //}
    }
}
