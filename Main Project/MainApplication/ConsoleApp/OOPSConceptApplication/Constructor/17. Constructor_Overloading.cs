using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Constructor_Overloading
    {
        //static void Main(string[] args)
        //{
        //    Overloading_User user = new Overloading_User(); // Default Constructor will be called
        //    Overloading_User user1 = new Overloading_User("Rohini Alavala", "Guntur"); // Parameterized Constructor will be called
        //    Console.WriteLine(user.name + ", " + user.location);
        //    Console.WriteLine(user1.name + ", " + user1.location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Overloading_User
    {
        public string name, location;
        // Default Constructor
        public Overloading_User()
        {
            name = "Suresh Dasari";
            location = "Hyderabad";
        }
        // Parameterized Constructor
        public Overloading_User(string a, string b)
        {
            name = a;
            location = b;
        }
    }
}
