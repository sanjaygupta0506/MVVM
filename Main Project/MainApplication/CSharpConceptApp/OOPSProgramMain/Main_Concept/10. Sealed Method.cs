using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Sealed_Method
    {
        //static void Main(string[] args)
        //{
        //    B c = new B();
        //    c.GetInfo();
        //    c.Test();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base Class A Test Method");
        }
    }

    public class B : A
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived Class B Method");
        }

        public override void Test()
        {
            Console.WriteLine("Derived Class B Test Method");
        }
    }

    //public class C : B
    //{
    //    // Compile time error - // Attempting to override F causes compiler error CS0239.
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine("Age: {0}", base.age);
    //    }

    //    public override void Test()
    //    {
    //        Console.WriteLine("Derived Class C Test Method");
    //    }
    //}
}
