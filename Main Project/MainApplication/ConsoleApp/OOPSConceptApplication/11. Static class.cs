using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    class Static_class
    {
        //static void Main(string[] args)
        //{
        //    SC_User.name = "Suresh Dasari";
        //    SC_User.location = "Hyderabad";
        //    SC_User.age = 32;
        //    Console.WriteLine("Name: {0}", SC_User.name);
        //    Console.WriteLine("Location: {0}", SC_User.location);
        //    Console.WriteLine("Age: {0}", SC_User.age);
        //    SC_User.Details();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    static class SC_User
    {
        // Static Variables
        public static string name;
        public static string location;
        public static int age;
        // Static Method
        public static void Details()
        {
            Console.WriteLine("Static Method");
        }

    }
}
