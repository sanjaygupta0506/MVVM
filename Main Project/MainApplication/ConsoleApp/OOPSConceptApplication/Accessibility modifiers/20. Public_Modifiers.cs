using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Accessibility_modifiers
{
    class Public_Modifiers
    {
        //static void Main(string[] args)
        //{
        //    Public_User u = new Public_User();
        //    u.Name = "Sanjay Gupta";
        //    u.Location = "Faridabad";
        //    u.Age = 32;
        //    u.GetUserDetails();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Public_User
    {
        public string Name;
        public string Location;
        public int Age;
        public void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
