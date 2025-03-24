using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Accessibility_modifiers
{
    class Protected_Modifiers
    {
        //static void Main(string[] args)
        //{
        //    Protected_User u = new Protected_User();
        //    // Complier Error
        //    // These are inaccessible due to protected specifier
        //    u.Name = "Suresh Dasari";
        //    u.Location = "Hyderabad";
        //    u.Age = 32;
        //    u.GetUserDetails();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Protected_User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
