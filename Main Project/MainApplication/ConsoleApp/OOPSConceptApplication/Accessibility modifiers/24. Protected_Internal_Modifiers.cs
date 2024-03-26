using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Accessibility_modifiers
{
    class Protected_Internal_Modifiers
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("**** Protected_Internal_Modifiers ***");
        //    Protected_Internal_User u = new Protected_Internal_User();
        //    u.Name = "Suresh Dasari";
        //    u.Name = "Suresh Dasari";
        //    u.Location = "Hyderabad";
        //    u.Age = 32;
        //    u.GetUserDetails();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Protected_Internal_User
    {
        protected internal string Name;
        protected internal string Location;
        protected internal int Age;
        protected internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
