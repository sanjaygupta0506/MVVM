using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._2._Locks
{
    public static class MonitorClass
    {
        private static int _counter;
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
            try
            {
                Monitor.Enter(_lockObject);
                for (var cnt = 0; cnt < 30; cnt++)
                {
                    _counter++;
                    Console.WriteLine("Thread - Monitor :" + _counter);
                }
            }
            finally
            {
                Monitor.Exit(_lockObject);
            }
        }
        //public static void Main(string[] args)
        //{
        //    MonitorClass.Execute();
        //    //Console.WriteLine($"Lock statement result: {Thread_Lock_2.Execute()}"); // Lock statement result: 300000
        //    Console.ReadLine();
        //}
    }
}
