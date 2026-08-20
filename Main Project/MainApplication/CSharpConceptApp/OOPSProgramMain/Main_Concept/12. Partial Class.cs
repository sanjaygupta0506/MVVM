using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_PartialClass
{
    public partial class Employee
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
    public partial class Employee
    {
        public int Age { get; set; }

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Partial_Class
    {
        static void Main()
        {
            Console.WriteLine("****Partial Class Example****");
            Employee emp = new Employee();

            emp.Name = "Sanjay";
            emp.Age = 35;

            emp.DisplayName();
            emp.DisplayAge();
            Console.ReadLine();
        }
    }
}
