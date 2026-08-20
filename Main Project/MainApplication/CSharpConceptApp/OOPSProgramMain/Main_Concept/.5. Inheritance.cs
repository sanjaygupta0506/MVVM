using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_Inheritance
{
    public class Inheritance
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Inheritance Example****");
        //    Dog myDog = new Dog();  // Create a Dog object
        //    Console.WriteLine("****Call the inherited method****");
        //    myDog.Eat();  // Call the inherited method
        //    Console.WriteLine("****Call the method of the Dog class****");
        //    myDog.Bark();  // Call the method of the Dog class
        //    Console.ReadLine();
        //}

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("The animal eats food");
            }
        }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("The dog barks");
            }
        }
    }

   
}
