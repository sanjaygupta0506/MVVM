using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    class Abstract_Method
    {
        //static void Main(string[] args)
        //{
        //    AM_User u = new AM_User();
        //    Console.WriteLine("****Abstract Method Example****");
        //    u.GetDetails("Suresh Dasari", "Hyderabad");
        //    Console.ReadLine();
        //}
    }

    abstract class AM_Info
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
        public int age = 32;
        public abstract void GetDetails(string x, string y);
    }

    class AM_User : AM_Info
    {
        public override void GetDetails(string a, string b)
        {
            Welcome();
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", age);
        }
    }
}
