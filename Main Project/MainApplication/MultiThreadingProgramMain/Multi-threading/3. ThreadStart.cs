using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading
{
    class ThreadStart
    {
        public ThreadStart(Action printTable)
        {
            PrintTable = printTable;
        }

        public Action PrintTable { get; }

        //static void Main(string[] ags)
        //{
        //    Thread th = new Thread(ThreadMethod);
        //    th.Start();
        //    Console.ReadLine();
        //}
        private static void ThreadMethod()
        {
            Console.WriteLine("Another Thread");
        }
    }
}
