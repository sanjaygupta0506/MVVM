using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Abstract_Class
    {
        //static void Main(string[] args)
        //{
        //    AC_User u = new AC_User();
        //    Console.WriteLine("****Abstract Class Example****");
        //    u.GetDetails("Suresh Dasari", "Hyderabad", 32);
        //    Console.ReadLine();
        //}
    }

    abstract class Info
    {
        public abstract void GetDetails(string x, string y, int z);
    }

    class AC_User : Info
    {
        public override void GetDetails(string a, string b, int c)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", c);
        }
    }
}
