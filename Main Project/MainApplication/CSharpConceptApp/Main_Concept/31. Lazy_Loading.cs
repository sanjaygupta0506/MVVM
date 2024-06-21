using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CSharpConceptApp.Main_Concept
{
    public class Lazy_Loading
    {
        //static void Main(string[] args)
        //{
        //    Company cmp = new Company();
        //    Console.WriteLine(cmp.CompanyName);
        //    foreach (var item in cmp.Employees.Value) //3. When we call cmp.Employees.Value then the Employee list will be populated here.  
        //    {
        //        Console.WriteLine(item.FirstName + " " + item.LastName);
        //    }
        //    Console.ReadLine();
        //}
    }
    //Employee Class which contains FirstName and LastName properties  
    public class Employee
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
    }

    public class Company
    {
        public string CompanyName;
        public Lazy<List<Employee>> Employees = null; //1. Mark Employees property as Lazy  
        public Company()
        {
            CompanyName = "MNC";
            Employees = new Lazy<List<Employee>>(() => getEmployees()); // 2. Asking the property to load values from getEmployees() method  
        }
        //Method to get Employees.  
        public List<Employee> getEmployees()
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Sridhar", LastName = "Adusumilli"
                }, new Employee
                {
                    FirstName = "Manas", LastName = "Mohapatra"
                }
            };
            return Employees;
        }
    }
}
