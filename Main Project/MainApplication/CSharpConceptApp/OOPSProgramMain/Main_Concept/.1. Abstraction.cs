using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_Abstraction
{
    public class Abstraction
    {
        //static void Main(string[] args)
        //{
        //    Animal animal = new Dog();
        //    Console.WriteLine("****Abstraction -> Abstract Class Example****");
        //    animal.AnimalSound();
        //    animal.Sleep();
        //    Console.WriteLine();
        //    IAnimal cat = new Cat();
        //    Console.WriteLine("****Abstraction -> Interface Example****");
        //    cat.AnimalSound();
        //    cat.Sleep();
        //    Console.ReadLine();
        //}
    }
    #region ****Abstraction -> Abstract Class Example****
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
    #endregion

    #region ****Abstraction -> Interface Example****
    interface IAnimal
    {
        void AnimalSound();
        void Sleep();
    }

    class Cat : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Cat Meows");
        }
        public void Sleep()
        {
            Console.WriteLine("Cat is Sleeping");
        }
    }
    #endregion

}
