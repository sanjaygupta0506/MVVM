using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Delegates
{
    // Declare Delegate
    public delegate void SampleDelegate1(int a, int b);
    class MathOperationsMD
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Result: {0}", x - y);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply Result: {0}", x * y);
        }
    }

    class MulticastDelegates
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Delegate Example****");
        //    MathOperationsMD m = new MathOperationsMD();
        //    // Instantiate delegate with add method
        //    SampleDelegate dlgt = m.Add;
        //    dlgt += m.Subtract;
        //    dlgt += m.Multiply;
        //    dlgt(100, 90);
        //    Console.ReadLine();
        //}

    }
}
