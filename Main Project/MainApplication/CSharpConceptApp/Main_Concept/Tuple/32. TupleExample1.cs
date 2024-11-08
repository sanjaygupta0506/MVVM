using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Tuple
{
    class TupleExample1
    {
        //static void Main()
        //{
        //    var values = new List<double>() { 10, 20, 30, 40, 50 };
        //    var result = Calulate(values);
        //    Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
        //    Console.ReadKey();
        //}
        //Declaring the return type as Tuple<int, double>
        private static (int, double) Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }


    }
}
