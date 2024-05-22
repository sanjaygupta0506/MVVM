using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Constructor
{

    // Normal Functionality

    //public class EmployeeDAL
    //{
    //    public List<Employee> SelectAllEmployees()
    //    {
    //        List<Employee> ListEmployees = new List<Employee>();
    //        ListEmployees.Add(new Employee() { Id = 1, Name="Sanjay", Department="IT"});
    //        ListEmployees.Add(new Employee() { Id = 2, Name="Ram", Department="Accounts"});
    //        ListEmployees.Add(new Employee() { Id = 3, Name = "Naresh", Department = "Production"});
    //        return ListEmployees;
    //    }
    //}


    //public class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //}


    //------------- Implement Constructor Dependency Injection

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee() { Id = 1, Name = "Sanjay", Department = "IT" });
            ListEmployees.Add(new Employee() { Id = 2, Name = "Ram", Department = "Accounts" });
            ListEmployees.Add(new Employee() { Id = 3, Name = "Naresh", Department = "Production" });
            return ListEmployees;
        }
    }
}
