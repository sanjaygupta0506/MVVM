using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading
{
    class Deadlock
    {
        private static object objA = new object();
        private static object objB = new object();

        private static void PerformTaskA()
        {
            lock(objB)
            {
                Thread.Sleep(1000);
                lock(objA)
                {

                }
            }
        }

        private static void PerformTaskB()
        {
            lock (objA)
            {
                Thread.Sleep(1000);
                lock (objB)
                {

                }
            }
        }

        //public static void Main(string[] args)
        //{
        //    Thread thread1 = new Thread(PerformTaskA);
        //    Thread thread2 = new Thread(PerformTaskB);
        //    thread1.Start();
        //    thread2.Start();
        //    Console.ReadLine();
        //}
    }
}
