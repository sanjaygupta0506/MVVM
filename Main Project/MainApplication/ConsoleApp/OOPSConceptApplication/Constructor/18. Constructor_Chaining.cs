using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Constructor
{
    class Constructor_Chaining
    {
        //static void Main(string[] args)
        //{
        //    Chaining_User user1 = new Chaining_User(" to", "tutlane");
        //    Console.WriteLine();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Chaining_User
    {
        public Chaining_User()
        {
            Console.Write("Hi, ");
        }
        public Chaining_User(string a) : this()
        {
            Console.Write(a);
        }
        public Chaining_User(string a, string b) : this("welcome")
        {
            Console.Write(a + " " + b);
        }
    }
}
