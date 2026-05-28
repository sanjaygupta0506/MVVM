using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Deppendency_Injection.Constructor
{
    // Normal

    //public class EmployeeBAL
    //{
    //    public EmployeeDAL employeeDAL;
    //    public List<Employee> GetAllEmployees()
    //    {
    //        employeeDAL = new EmployeeDAL();
    //        return employeeDAL.SelectAllEmployees();
    //    }
    //}


    // Implement DI

    public class EmployeeBAL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBAL(IEmployeeDAL empDAL)
        {
            this.employeeDAL = empDAL;
        }

        public List<Employee> GetAllEmployess()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}
