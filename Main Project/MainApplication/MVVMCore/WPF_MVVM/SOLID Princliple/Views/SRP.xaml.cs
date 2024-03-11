using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.SRP
{
    /// <summary>
    /// Interaction logic for SRP.xaml
    /// </summary>
    public partial class SRP : WslDialog
    {
        private int Basic;
        private int HRA;
        private int OtherAllowance;
        Employee employee = new Employee();
       
        public SRP()
        {
            InitializeComponent();
        }

        
        public double CalculateSalary(Employee employee)
        {
            double Salary = 0.0;
            //Calculate employee's salary
            if (tbBasic.Text != "")
            {
                Basic = Convert.ToInt32(tbBasic.Text);
                HRA = Convert.ToInt32(tbHRA.Text);
                OtherAllowance = Convert.ToInt32(tbOA.Text);

                employee.Name = "Sanjay";
                Salary = Basic + HRA + OtherAllowance;
                
            }
            return Salary;
        }

        public double CalculateBonus(Employee employee)
        {
           

            double Bonus = 0.0;
            //Calculate employee's salary
            if (tbBasic.Text != "")
            {
                Basic = Convert.ToInt32(tbBasic.Text);
                HRA = Convert.ToInt32(tbHRA.Text);
                OtherAllowance = Convert.ToInt32(tbOA.Text);

                employee.Name = "Sanjay";
                // Calculate employee's bonus
                Bonus  = (((Basic + HRA + OtherAllowance) * 10) / 100);

            }
            return Bonus;
        }

        

       

       
        private void tbOA_MouseLeave(object sender, MouseEventArgs e)
        {
            tbSalary.Text = CalculateSalary(employee).ToString();
            tbBonus.Text = CalculateBonus(employee).ToString();
        }
    }
}
