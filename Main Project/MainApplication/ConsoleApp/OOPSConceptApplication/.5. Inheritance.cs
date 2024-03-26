using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Inheritance
    {
        //static void Main(string[] args)
        //{
        //    Details d = new Details();
        //    d.Name = "Suresh Dasari";
        //    // Compile Time Error
        //    //d.Location = "Hyderabad";
        //    d.Age = 32;
        //    d.GetUserInfo("Hyderabad");
        //    d.GetAge();
        //    Console.WriteLine("\nPress Any Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    public class I_User
    {
        public string Name;
        private string Location;
        public I_User()
        {
            Console.WriteLine("Base Class Constructor");
        }
        public void GetUserInfo(string loc)
        {
            Location = loc;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
        }
    }

    public class Details : I_User
    {
        public int Age;
        public Details()
        {
            Console.WriteLine("Child Class Constructor");
        }
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
