using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Accessibility_modifiers
{
    class Private_Protected_Modifiers : Private_Protected_User
    {
        //static void Main(string[] args)
        //{
        //    Private_Protected_User u = new Private_Protected_User();
        //    Private_Protected_Modifiers p = new Private_Protected_Modifiers();
        //    string MyName = "Sanjay";
        //    MyName = "Sanjay Gupta";
           
        //    // Complier Error
        //    // protected members can only accessible with derived classes
        //    //u.Name = "Suresh Dasari";
        //    p.Name = "Suresh Dasari";
        //    p.Location = "Hyderabad";
        //    p.Age = 32;
        //    p.GetUserDetails();
        //    Console.WriteLine(MyName);
        //    Console.WriteLine("\n Name Press Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    class Private_Protected_User
    {
        private protected string Name;
        private protected string Location;
        private protected int Age;
        private protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
