using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_AbstractClass
{
    public class Abstract_Class
    {
        //static void Main(string[] args)
        //{
        //    Animal animal = new Dog();
        //    Console.WriteLine("****Abstract Class Example****");
        //    animal.AnimalSound();
        //    animal.Sleep(); 
        //    Console.ReadLine();
        //}
    }

    abstract class Animal
    {
        public abstract void AnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Animal is Sleeping");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
}
