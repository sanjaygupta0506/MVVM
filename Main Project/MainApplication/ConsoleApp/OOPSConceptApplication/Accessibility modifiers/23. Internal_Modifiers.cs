using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Accessibility_modifiers
{
    class Internal_Modifiers
    {
        //static void Main(string[] args)
        //{
        //    Internal_User u = new Internal_User();
        //    u.Name = "Suresh Dasari";
        //    u.Name = "Suresh Dasari";
        //    u.Location = "Hyderabad";
        //    u.Age = 32;
        //    u.GetUserDetails();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Internal_User
    {
        internal string Name;
        internal string Location;
        internal int Age;
        internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
