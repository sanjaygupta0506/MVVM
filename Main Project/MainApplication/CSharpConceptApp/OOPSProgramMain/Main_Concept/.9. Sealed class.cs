using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    class Sealed_class
    {
        //static void Main(string[] args)
        //{
        //    Users d = new Users();
        //    d.GetInfo();
        //    //d.GetInfo();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    // Base Class
    sealed class Users
    {
        public string name = "Suresh Dasari";
        public string location = "Hyderabad";
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    ////Derived Class  - Sealed class cannot be inherit
    //public class SC_Details : Users
    //{

    //    public int age = 32;
    //    public void GetAge()
    //    {
    //        Console.WriteLine("Age: {0}", age);
    //    }
    //}
}
