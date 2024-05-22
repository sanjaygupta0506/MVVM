using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading
{
    class Thread_With_Parameter
    {
        //static void Main(string[] args)
        //{
        //    Thread th = new Thread(ThreadMethod);
        //    th.Start("Sanjay");
        //    Console.ReadLine();
        //}

        private static void ThreadMethod(object args)
        {
            Console.WriteLine(args.ToString());
        }
    }
}
