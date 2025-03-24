using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Copy_Constructor
    {
        //static void Main(string[] args)
        //{
        //    // User object with Parameterized constructor
        //    Copy_User user = new Copy_User("Sanjay Gupta", "Faridabad");
        //    // Another User object (user1) by copying user details
        //    Copy_User user1 = new Copy_User(user);
        //    user1.name = "Kanchan Gupta";
        //    user1.location = "Faridabad";
        //    Console.WriteLine(user.name + ", " + user.location);
        //    Console.WriteLine(user1.name + ", " + user1.location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Copy_User
    {
        public string name, location;
        // Parameterized Constructor
        public Copy_User(string a, string b)
        {
            name = a;
            location = b;
        }
        // Copy Constructor
        public Copy_User(Copy_User user)
        {
            name = user.name;
            location = user.location;
        }
    }
}
