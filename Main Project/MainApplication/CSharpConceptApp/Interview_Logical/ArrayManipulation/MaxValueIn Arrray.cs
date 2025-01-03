using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Interview_Logical.ArrayManipulation
{
    class MaxValueIn_Arrray
    {
        public static void MaximumMinimumElementArray()
        {
            int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);

            //int[] arr = { 8, 3, 5, -1, 2 };
            //Console.WriteLine("Minimum number is " + arr.Min());
            //Console.WriteLine("Maximum number is " + arr.Max());
            
            
            Console.Read();
        }

        public static void Main(string[] args)
        {
            MaximumMinimumElementArray();
        }
    }
}
