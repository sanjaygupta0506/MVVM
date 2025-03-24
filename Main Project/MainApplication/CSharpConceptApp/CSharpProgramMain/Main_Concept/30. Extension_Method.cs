using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Main_Concept
{
    // Main Class
    public class ClassTobeExtendeded
    {
        public void Display()
        {
           Console.WriteLine("I am Display Method");
        }
        public void Print()
        {
            Console.WriteLine("I am Print Method");
        }
    }

    //Extension method
    public static class Extension_Method
    {
        public static void NewMethod(this ClassTobeExtendeded obj)
        {
            Console.WriteLine("Hello I am Extensive Method");
        }
    }

    // Call Main Class method and Extension method
    class Calling_Extension_Method
    {
        //static void Main(string[] args)
        //{
        //    ClassTobeExtendeded obj = new ClassTobeExtendeded();
        //    obj.Display();
        //    obj.Print();
        //    obj.NewMethod();
        //    Console.ReadKey();
        //}
    }
}
