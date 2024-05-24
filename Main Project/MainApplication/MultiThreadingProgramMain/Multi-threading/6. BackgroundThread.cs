using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConceptApp.Multi_threading
{
    class BackgroundThread
    {
        // Main method 
        //static void Main(string[] args)
        //{
        //    // Creating and initializing thread 
        //    Thread thr = new Thread(mythread);

        //    // Name of the thread is Mythread 
        //    thr.Name = "Mythread";
        //    thr.Start();

        //    // IsBackground is the property of Thread 
        //    // which allows thread to run in the background 
        //    thr.IsBackground = true;

        //    Console.WriteLine("Main Thread Ends!!");
        //    Console.ReadLine();
        //}

        // Static method 
        static void mythread()
        {

            // Display the name of the  
            // current working thread 
            Console.WriteLine("In progress thread is: {0}",
                                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Completed thread is: {0}",
                              Thread.CurrentThread.Name);
        }

    }
}
