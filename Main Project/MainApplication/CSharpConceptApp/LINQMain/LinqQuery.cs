using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.LINQMain
{
    public class LinqQuery
    {
        public static void GetEvenNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void GetNumbersbyOrderby()
        {
            int[] numbers = { 1, 3, 4, 7, 2, 9, 8, 5, 10, 6 };
            int[] numbers1 = { 1, 3, 2, 1, 2, 5, 8, 5, 1, 6 };
            int[] numbers2 = { 1, -3, 2, 1, -2, 5, -8, 5, -1, 6 };
            string[] names = { "Sanjay", "Kanchan", "Devansh", "Divyanshi" };


            var sorted = numbers.OrderBy(x => x);
            Console.WriteLine("Order by Numbers:");
            foreach (var num in sorted)
            {
                Console.WriteLine(num);
            }

            var first = numbers.First();
            Console.WriteLine("First Number:");
            Console.WriteLine(first);

            var item = numbers.FirstOrDefault();
            Console.WriteLine("FirstOrDefault Number:");
            Console.WriteLine(item);

            var squares = numbers.Select(x => x * x);
            Console.WriteLine("Squares of Numbers:");
            foreach (var num in squares)
            {
                Console.WriteLine(num);
            }

            var distinctNumbers = numbers1.Distinct();
            Console.WriteLine("Distinct Numbers:");
            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num);
            }

            int totalCount = numbers.Count();
            Console.WriteLine("Total Count of Numbers:");
            Console.WriteLine(totalCount);

            bool exists = numbers2.Any(x => x > 25);
            Console.WriteLine("Numbers are exists:");
            Console.WriteLine(exists);

            bool allpositive = numbers2.All(x => x > 0);
            Console.WriteLine("All Numbers are Positive:");
            Console.WriteLine(allpositive);

            var groupName = names.GroupBy(x => x[0]);
            foreach(var group in groupName)
            {
                Console.WriteLine(group.Key);
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
            }

        }

        public static void Main(string[] args)
        {
            //GetEvenNumbers();
            //GetNumbersbyOrderby();
            Console.ReadLine();
        }
    }
}
