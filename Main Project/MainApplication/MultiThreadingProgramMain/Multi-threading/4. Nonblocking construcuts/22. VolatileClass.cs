using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading._4._Nonblocking_construcuts
{
    public static class VolatileClass
    {
        static string result;
        static volatile bool done;
        static void SetVolatile()
        {
            result = "Csharpcorner.com";
            done = true;
        }
        //static void Main(string[] args)
        //{
        //    new Thread(new System.Threading.ThreadStart(SetVolatile)).Start();
        //    Thread.Sleep(200);
        //    if (done)
        //    {
        //        Console.WriteLine(result);
        //    }
        //    Console.Read();
        //}
    }
}
