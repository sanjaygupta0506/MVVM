using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Parameterized_Constructor
    {
        //static void Main(string[] args)
        //{
        //    // The constructor will be called automatically once the instance of class created
        //    Parameterized_User user = new Parameterized_User("Suresh Dasari", "Hyderabad");
        //    Console.WriteLine(user.name);
        //    Console.WriteLine(user.location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    public class Parameterized_User
    {
        public string name, location;
        // Parameterized Constructor
        public Parameterized_User(string a, string b)
        {
            name = a;
            location = b;
        }
    }
}
