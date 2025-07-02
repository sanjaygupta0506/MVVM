using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.OOPSProgramMain.Main_Concept
{
    
    interface IShape
    {
        double GetArea();
    }
    interface IColor
    {
        string GetColor();
    }
    class Multiple_Inheritance : IShape, IColor
    {
        public Multiple_Inheritance(double length, double width, string color)
        {
            this.Color = color;
            this.Width = width;
            this.Length = length;
        }
        private double Length;
        private double Width;
        private string Color;
        public double GetArea()
        {
            return Length * Width;
        }

        public string GetColor()
        {
            return Color;
        }

        //static void Main(string[] args)
        //{
        //    Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance(5, 10, "blue");
        //    Console.WriteLine("Area of rectangle: " + multiple_Inheritance.GetArea());
        //    Console.WriteLine("Color of rectangle: " + multiple_Inheritance.GetColor());
        //    Console.ReadLine();
        //}
    }
}
