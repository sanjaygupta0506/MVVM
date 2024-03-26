using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Static_Constructor
    {
        //static void Main(string[] args)
        //{
        //    // Both Static and Default constructors will invoke for first instance
        //    Static_User user = new Static_User();
        //    // Only Default constructor will invoke
        //    Static_User user1 = new Static_User();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Static_User
    {
        // Static Constructor
        static Static_User()
        {
            Console.WriteLine("I am Static Constructor");
        }
        //Default Constructor
        public Static_User()
        {
            Console.WriteLine("I am Default Constructor");
        }
    }
}
