using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_Sealedclass
{
    class Sealed_class
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Sealed Class Example****");
        //    SealedClass sealedClass = new SealedClass();    
        //    sealedClass.Display();
        //    Console.ReadLine();
        //}
    }

    sealed class SealedClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }
    class DerivedClass //: SealedClass // This will cause a compile-time error
    {
        //public void Show()
        //{
        //    Console.WriteLine("This is a derived class.");
        //}
    }

    


}
