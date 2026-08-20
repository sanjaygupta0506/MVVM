using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_MultipleInheritance
{
    
    interface IAnimal
    {
        void Eat();
    }
    interface IBird
    {
        void Fly();
    }   
    class Multiple_Inheritance : IAnimal, IBird
    {
        public void Eat()
        {
            Console.WriteLine("The animal eats food");
        }

        public void Fly()
        {
            Console.WriteLine("The bird flies");
        }   

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Multiple Inheritance Example****");
        //    Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance();
        //    multiple_Inheritance.Eat();
        //    multiple_Inheritance.Fly();
        //    Console.ReadLine();
        //}
    }
}
