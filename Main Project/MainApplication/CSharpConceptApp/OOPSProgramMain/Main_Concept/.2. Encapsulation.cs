using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_Encapsulation
{
    public class Encapsulation
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Encapsulation Example****");
        //    Encapsulation_User u = new Encapsulation_User();
        //    // set accessor will invoke
        //    u.Name = "Sanjay Gupta";
        //    // set accessor will invoke
        //    u.Location = "Faridabad";
        //    // get accessor will invoke
        //    Console.WriteLine("Name: " + u.Name);
        //    // get accessor will invoke
        //    Console.WriteLine("Location: " + u.Location);
        //    Console.ReadLine();
        //}
    }

    public class Encapsulation_User
    {
        private string name;
        private string location;
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
    }

}
