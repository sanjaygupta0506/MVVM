using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.LINQMain
{
    public class LinqQuery
    {
        public static void CommonQuery()
        {
            int[] numbers = { 1, 3, 4, 7, 2, 9, 8, 5, 10, 6 };
            int[] numbers1 = { 1, 3, 2, 1, 2, 5, 8, 5, 1, 6 };
            int[] numbers2 = { 1, -3, 2, 1, -2, 5, -8, 5, -1, 6 };
            string[] names = { "Sanjay", "Kanchan", "Devansh", "Divyanshi" };

            #region GetEvenNumbers
            int[] unSortednumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = unSortednumbers.Where(x => x % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            #endregion

            #region OrderBy
            var sorted = numbers.OrderBy(x => x);
            Console.WriteLine("Order by Numbers:");
            foreach (var num in sorted)
            {
                Console.WriteLine(num);
            }
            #endregion

            #region First & FirstOrDefault
            var first = numbers.First();
            Console.WriteLine("First Number:");
            Console.WriteLine(first);

            var item = numbers.FirstOrDefault();
            Console.WriteLine("FirstOrDefault Number:");
            Console.WriteLine(item);
            #endregion

            #region Select & Distinct
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
            #endregion

            #region Count & Any
            int totalCount = numbers.Count();
            Console.WriteLine("Total Count of Numbers:");
            Console.WriteLine(totalCount);

            bool exists = numbers2.Any(x => x > 25);
            Console.WriteLine("Numbers are exists:");
            Console.WriteLine(exists);
            #endregion

            #region All
            bool allpositive = numbers2.All(x => x > 0);
            Console.WriteLine("All Numbers are Positive:");
            Console.WriteLine(allpositive);
            #endregion

            #region GroupBy
            var groupName = names.GroupBy(x => x[0]);
            foreach (var group in groupName)
            {
                Console.WriteLine(group.Key);
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
            }
            #endregion

            #region Dictionary & HashSet

            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1, "sanjay");
            emp.Add(2, "kanchan");
            emp.Add(3, "devansh");
            emp.Add(4, "divyanshi");
            Console.WriteLine("Dictionary of Employees:");
            foreach (var e in emp)
            {
                Console.WriteLine($"ID: {e.Key}, Name: {e.Value}");
            }

            HashSet<string> emp1 = new HashSet<string>();
            emp1.Add("sanjay");
            emp1.Add("kanchan");
            emp1.Add("devansh");
            emp1.Add("divyanshi");
            Console.WriteLine("HashSet of Employees:");
            foreach (var e in emp1)
            {
                Console.WriteLine(e);
            }
            #endregion

            #region Sort Employee List by Salary
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sanjay", Salary = 50000 },
                new Employee { Id = 2, Name = "Kanchan", Salary = 60000 },
                new Employee { Id = 3, Name = "Devansh", Salary = 55000 },
                new Employee { Id = 4, Name = "Divyanshi", Salary = 70000 }
            };
            Console.WriteLine("Sort Employee List by Salary:");
            var sortedEmployees = employees.OrderBy(e => e.Salary);
            foreach (var semp in sortedEmployees)
            {
                Console.WriteLine(semp.Name);
            }

            #endregion

            #region Delegate and Lambda
            Func<int, int, int> add = (x, y) => x + y;
            int result = add(5, 10);
            #endregion
        }

        //public static void Main(string[] args)
        //{
        //    CommonQuery();
        //    Console.ReadLine();
        //}
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
