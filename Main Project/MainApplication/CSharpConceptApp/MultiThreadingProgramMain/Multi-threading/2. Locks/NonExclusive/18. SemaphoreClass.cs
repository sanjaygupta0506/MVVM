using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._2._Locks
{
    class SemaphoreClass
    {
        public static readonly Semaphore semaphore = new Semaphore(2, 4);
        public static void Execute()
        {
            for (var cnt = 0; cnt < 6; cnt++)
            {
                Thread thread = new Thread(DoWork)
                {
                    Name = "Thread " + cnt
                };
                thread.Start();
            }
        }
        private static void DoWork()
        {
            try
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} waits the lock");
                semaphore.WaitOne();
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} enters critical section");
                Thread.Sleep(500);
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} exits critical section");
            }
            finally
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} releases the lock");
                semaphore.Release();
            }
        }
        //public static void Main(string[] args)
        //{
        //    SemaphoreClass.Execute();
        //    //Console.WriteLine($"Lock statement result: {SpinLockClass.Execute()}"); // Lock statement result: 300000
        //    Console.ReadLine();
        //}
    }
}
