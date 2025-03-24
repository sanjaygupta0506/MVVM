using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._2._Locks
{
    public abstract class InterLockedClass
    {
        private static int _counter;
        public abstract int Increment(ref int location);

        private static readonly object _lockObject = new object();
        public static int Execute()
        {
            var thread1 = new Thread(IncrementCounter);
            var thread2 = new Thread(IncrementCounter);
            var thread3 = new Thread(IncrementCounter);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            return _counter;
        }
        private static void IncrementCounter()
        {
            //lock (_lockObject)
            {
                for (var cnt = 0; cnt < 10; cnt++)
                {
                    //_counter++;
                    Interlocked.Increment(ref _counter);
                    Thread.Sleep(100);
                    Console.WriteLine("Thread - Interlocked : " + _counter);
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    InterLockedClass.Execute();
        //    //Console.WriteLine($"Lock statement result: {Thread_Lock_2.Execute()}"); // Lock statement result: 300000
        //    Console.ReadLine();
        //}
    }
}
