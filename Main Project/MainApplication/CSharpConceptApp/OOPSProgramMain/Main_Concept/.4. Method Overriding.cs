using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_MethodOverriding
{
    public class Method_Overriding
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Method Overriding Example****");
        //    Animal myAnimal = new Animal();  // Create a Animal object
        //    Animal myDog = new Dog();  // Create a Dog object   
        //    Console.WriteLine("****Virtual****");
        //    myAnimal.animalSound();  // Call the method on the Animal object
        //    Console.WriteLine("****Override****");
        //    myDog.animalSound();  // Call the method on the Dog object
        //    Console.ReadLine();
        //}

        class Animal
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog barks");
            }
        }
    }

    
    

    


}
