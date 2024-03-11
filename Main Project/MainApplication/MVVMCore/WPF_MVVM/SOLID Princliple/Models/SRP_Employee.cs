using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.SRP
{
    public class Employee
    {
        #region Normal Structure

        //public string Name { get; set; }
        //public string Address { get; set; }
        //public double Salary { get; set; }
        //public double Bonus { get; set; }

        //public void CalculateSalary()
        //{
        //    // Calculate employee's salary
        //}

        //public void CalculateBonus()
        //{
        //    // Calculate employee's bonus
        //}

        #endregion


        #region Single Responsibility Principle (SRP)

        public string Name { get; set; }
        public string Address { get; set; }

        #endregion
    }

    public class SalaryCalculator
    {
        
    }
}
