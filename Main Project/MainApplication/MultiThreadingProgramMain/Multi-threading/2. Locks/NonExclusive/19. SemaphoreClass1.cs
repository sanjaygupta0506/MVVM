using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._2._Locks.NonExclusive
{
    class SemaphoreClass1
    {
        static Semaphore semaphore = new Semaphore(5, 5);
        //static void Main(string[] args)
        //{
        //    Task.Factory.StartNew(() =>
        //    {
        //        for (int i = 1; i <= 15; ++i)
        //        {
        //            PrintSomething(i);
        //            if (i % 5 == 0)
        //            {
        //                Thread.Sleep(2000);
        //            }
        //        }
        //    });
        //    Console.ReadLine();
        //}
        public static void PrintSomething(int number)
        {
            semaphore.WaitOne();
            Console.WriteLine(number);
            semaphore.Release();
        }
    }
}
