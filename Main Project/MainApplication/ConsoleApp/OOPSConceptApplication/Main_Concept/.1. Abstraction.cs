using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    public class Abstraction
    {
        //static void Main(string[] args)
        //{
        //    Laptop l = new Laptop();
        //    l.Brand = "Dell";
        //    l.Model = "Inspiron 14R";
        //    l.LaptopDetails();
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}
    }

    public class Laptop
    {
        // Declare Varible
        private string brand;
        private string model;

        // Declare Property
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Declare Method/Function
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        public void LaptopKeyboard()
        {
            Console.WriteLine("Type using Keyword");
        }
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotheBoard Information");
        }
        private void InternalProcessor()
        {
            Console.WriteLine("Processor Information");
        }
    }
}
