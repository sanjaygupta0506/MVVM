using AllInterview_Coding.AllInterview.MostlyAsked_Coding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInterview_Coding.AllInterview.MostlyAsked_Coding.ViewModels
{
    public class VirtualizationViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public VirtualizationViewModel()
        {
                Customers = new ObservableCollection<Customer>();
                for (int i = 1; i <= 10000; i++)
                {
                    Customers.Add(new Customer 
                    { 
                        CustID = i, 
                        CustName = "Customer"  + i, 
                        CustAge = "Age"  + i,
                        CustDepartment = "Department"  + i
                    });
            }
        }
    }
}
