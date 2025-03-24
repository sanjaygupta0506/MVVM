using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Method_Overriding
    {
        //static void Main(string[] args)
        //{
        //    //DClass d = new DClass();
        //    //d.GetInfo();
        //    //BClass b = new BClass();
        //    //b.GetInfo();
        //    //Console.WriteLine("\nPress Enter Key to Exit..");
        //    //Console.ReadLine();

        //    Automobile a1 = new Car();
        //    a1.Print("Tata");
        //    a1.Print();

        //    Car c1 = (Car)a1;
        //    c1.Print("Mahindra");

        //    //Car c2 = new Automobile();
        //    //c2.Print();

        //    Console.ReadLine();
        //}



    }

    // Base Class
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }

    // Derived Class
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
    }


    public class Automobile
    {
        public static int count;
        public Automobile()
        {
            count = 5;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Automobile: {count}");
        }
        public void Print(string brand)
        {
            Console.WriteLine($"Automobile: {brand}");
        }
    }
    public class Car : Automobile
    {
        public override void Print()
        {
            Console.WriteLine($"Car: {count}");
        }
        public void Print(string brand)
        {
            Console.WriteLine($"Car: {brand}");
        }
    }


}
