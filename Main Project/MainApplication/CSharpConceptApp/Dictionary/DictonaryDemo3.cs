using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Dictionary
{
    class DictonaryDemo3
    {
        //static void Main(string[] args)
        //{
        //    // Collection initializer
        //    // Initializing the collection directly at the time of declaration
        //    Dictionary<int, Employee1> dictionaryEmployees = new Dictionary<int, Employee1>()
        //    {
        //        { 101, new Employee1 {ID=101, Name="Pranaya", Gender="Male", Salary = 20000}},
        //        { 102, new Employee1 {ID=101, Name="Priyanka", Gender="Female", Salary = 30000}},
        //        { 103, new Employee1 {ID=101, Name="Anurag", Gender="Male", Salary = 40000}}
        //    };

        //    //To get all the values in the dictionary use Values property
        //    Console.WriteLine("All employees objects in Employee Dictionary");
        //    foreach (Employee1 emp in dictionaryEmployees.Values)
        //    {
        //        Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
        //                       emp.ID, emp.Name, emp.Gender, emp.Salary);
        //    }

        //    Console.ReadKey();
        //}
    }

        public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }

}
