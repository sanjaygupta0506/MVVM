using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Encapsulation
    {
        //static void Main(string[] args)
        //{
        //    Encapsulation_User u = new Encapsulation_User();
        //    // set accessor will invoke
        //    u.Name = "Suresh Dasari";
        //    // set accessor will invoke
        //    u.Location = "Hyderabad";
        //    // get accessor will invoke
        //    Console.WriteLine("Name: " + u.Name);
        //    // get accessor will invoke
        //    Console.WriteLine("Location: " + u.Location);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    public class Encapsulation_User
    {
        private string location;
        private string name;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

}
