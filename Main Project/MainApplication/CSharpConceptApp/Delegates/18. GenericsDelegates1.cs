using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Generics
{
    // Declare Generic Delegate
    public delegate T SampleDelegate<T>(T a, T b);
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    class GenericsDelegates1
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Generic Delegate Example****");
        //    MathOperations m = new MathOperations();
        //    // Instantiate delegate with add method
        //    SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Add);
        //    Console.WriteLine("Addition Result: " + dlgt(100, 90));
        //    // Instantiate delegate with subtract method
        //    dlgt = m.Subtract;
        //    Console.WriteLine("Subtraction Result: " + dlgt(100, 90));
        //    Console.ReadLine();
        //}

    }
}
