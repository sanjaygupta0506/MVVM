using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Default_Constructor
    {
        //static void Main(string[] args)
        //{
        //    // The constructor will be called automatically once the instance of class created
        //    Default_User user = new Default_User();
        //    Console.WriteLine(user.name);
        //    Console.WriteLine(user.location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Default_User
    {
        public string name, location;
        // Default Constructor
        public Default_User()
        {
            name = "Suresh Dasari";
            location = "Hyderabad";
        }
    }
}
