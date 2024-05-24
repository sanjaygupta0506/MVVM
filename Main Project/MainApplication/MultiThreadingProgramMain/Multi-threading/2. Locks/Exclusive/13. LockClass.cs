using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace CSharpConceptApp.Multi_threading._2._Locks
{
    namespace Monitor_Lock
    {
        class Printer
        {
           // private static readonly object _lockObject = new object();
            public void PrintTable()
            {
                lock (this)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine("Thread - Lock : " + i);
                    }
                }
            }
        }
        class LockClass
        {
            //public static void Main(string[] args)
            //{
            //    Printer p = new Printer();
            //    Thread t1 = new Thread(() => p.PrintTable());
            //    Thread t2 = new Thread(() => p.PrintTable());
            //    t1.Start();
            //    t2.Start();
            //    Console.ReadLine();
            //}
        }
    }
}
