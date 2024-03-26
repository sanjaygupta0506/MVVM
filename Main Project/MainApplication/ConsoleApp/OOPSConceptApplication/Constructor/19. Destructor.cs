using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    class Destructor
    {
        //static void Main(string[] args)
        //{
        //    Details();
        //    GC.Collect();
        //    Console.ReadLine();
        //}
        //public static void Details()
        //{
        //    // Created instance of the class
        //    Destructor_User user = new Destructor_User();
        //}
    }

    class Destructor_User
    {
        public Destructor_User()
        {
            Console.WriteLine("An Instance of class created");
        }
        // Destructor
        ~Destructor_User()
        {
            Console.WriteLine("An Instance of class destroyed");
        }
    }
}
