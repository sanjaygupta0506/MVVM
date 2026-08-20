using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_SealedMethod
{
    public class Sealed_Method
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Sealed Method Example****");
        //    Parent parent = new Child();
        //    parent.Show();
        //    Console.ReadLine();
        //}
    }
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Base Class Parent Method");
        }
    }
    public class Child : Parent
    {
        public sealed override void Show()
        {
            Console.WriteLine("Derived Class Child Method");
        }
    }
    public class GrandChild : Child
    {
        //public override void Show() // This will cause a compile-time error
        //{
        //    Console.WriteLine("Derived Class GrandChild Method");
        //}
    }
}
