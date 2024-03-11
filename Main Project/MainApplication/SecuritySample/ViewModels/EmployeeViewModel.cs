using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainApplication.SecuritySample
{
  public class EmployeeViewModel : SecurityViewModelBase
  {
    public EmployeeViewModel() : base()
    {
      EmployeeID = 1;
      FirstName = "Sanjay";
      LastName = "Gupta";
      Salary = 75000;
      SSN = "555-55-5555";
    }

    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public string SSN { get; set; }

    protected override void LoadControlsToSecure(string containerName)
    {
      base.LoadControlsToSecure(containerName);

      ControlsToSecure = new List<SecurityControl>
    {
        new SecurityControl
        {
            ContainerName = "EmployeeControl",
            ElementIdentifier = "NewButton",
            Mode = "collapsed",
            RolesAsString = "Users123,Supervisor"
        },
        new SecurityControl
        {
            ContainerName = "EmployeeControl",
            ElementIdentifier = "EmployeeID",
            Mode = "readonly",
            RolesAsString = "Admin,Supervisor"
        },
        new SecurityControl
        {
            ContainerName = "EmployeeControl",
            ElementIdentifier = "Salary",
            Mode = "hidden",
            RolesAsString = "Admin"
        },
        new SecurityControl
        {
            ContainerName = "EmployeeControl",
            ElementIdentifier = "SSN",
            Mode = "disabled",
            RolesAsString = "Supervisor"
        },
        new SecurityControl
        {
            ContainerName = "EmployeeControl",
            ElementIdentifier = "SaveButton",
            Mode = "disabled",
            RolesAsString = "Admin,Supervisor"
        }
    };
    }

  }

}
