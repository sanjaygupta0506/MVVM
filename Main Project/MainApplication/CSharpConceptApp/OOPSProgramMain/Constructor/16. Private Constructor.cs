using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Private_Constructor
    {
        //static void Main(string[] args)
        //{
        //    // The following comment line will throw an error because constructor is inaccessible
        //    //User user = new User();

        //    // Only Default constructor with parameters will invoke
        //    Private_User user1 = new Private_User("Suresh Dasari", "Hyderabad");
        //    Console.WriteLine(Private_User.name + ", " + Private_User.location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Private_User
    {
        // private Constructor
        private Private_User()
        {
            Console.WriteLine("I am Private Constructor");
        }
        public static string name, location;
        // Default Constructor
        public Private_User(string a, string b)
        {
            name = a;
            location = b;
        }
    }
}
