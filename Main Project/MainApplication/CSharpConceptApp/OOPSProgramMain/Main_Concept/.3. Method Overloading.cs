using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_MethodOverloading
{
    public class Method_Overloading
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Method Overloading Example****");
        //    Calculate c = new Calculate();
        //    var result = c.AddNumbers(1, 2);
        //    Console.WriteLine("Add Two integer Numbers : {0}", result);
        //    int result1 = c.AddNumbers(1, 2, 3);
        //    Console.WriteLine("Add Three integer Numbers : {0}", result1);
        //    double result2 = c.AddNumbers(1.5, 2.5);
        //    Console.WriteLine("Add Two Double Numbers : {0}", result2);
        //    Console.ReadLine();
        //}
    }

    public class Calculate
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        public double AddNumbers(double a, double b)
        {
            return a + b;
        }
    }
}
