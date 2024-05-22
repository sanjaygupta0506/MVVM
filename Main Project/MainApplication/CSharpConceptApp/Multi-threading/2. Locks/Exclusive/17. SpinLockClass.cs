using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._2._Locks
{
    public static class SpinLockClass
    {
        private static bool lockAquired = false;
        private static int _counter;
        private static SpinLock spinLock = new SpinLock();

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
                if (lockAquired)
                {
                    Thread.Sleep(100);
                }
                if(lockAquired == true)
                {
                    lockAquired = false;
                    spinLock.Enter(ref lockAquired);
                    for (var cnt = 0; cnt < 100000; cnt++)
                    {
                        _counter++;
                        Console.WriteLine("Thread - SpinLock : " + _counter);
                        Console.ReadLine();
                    }
                }
                else
                {
                    spinLock.Enter(ref lockAquired);
                    for (var cnt = 0; cnt < 100000; cnt++)
                    {
                        _counter++;
                        Console.WriteLine("Thread - SpinLock : " + _counter);
                        Console.ReadLine();
                    }
                }
                
            }
            finally
            {
                if (lockAquired)
                {
                    lockAquired = false;
                    spinLock.Exit();
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    SpinLockClass.Execute();
        //    //Console.WriteLine($"Lock statement result: {SpinLockClass.Execute()}"); // Lock statement result: 300000
        //    Console.ReadLine();
        //}
    }
}
