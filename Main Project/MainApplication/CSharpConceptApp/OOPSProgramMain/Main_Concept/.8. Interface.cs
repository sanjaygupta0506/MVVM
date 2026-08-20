using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_Interface
{
    class Interface
    {
        //static void Main(string[] args)
        //{
        //    IAnilmal animal = new Dog();
        //    Console.WriteLine("****Interface Example****");
        //    animal.AnimalSound();
        //    animal.Eat();
        //    Console.ReadLine();
        //}
    }

    interface IAnilmal
    {
        void AnimalSound();
        void Eat();
    }

    public class Dog : IAnilmal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Dog Barks");
        }
        public void Eat()
        {
            Console.WriteLine("Dog Eats");
        }
    }
}

    







