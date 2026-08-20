using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept_StaticClass
{
    class Static_class
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("****Static Class Example****");
        //    int a = 10;
        //    int b = 5;
        //    Console.WriteLine($"Addition: {Calculator.Add(a, b)}");
        //    Console.WriteLine($"Subtraction: {Calculator.Subtract(a, b)}");
        //    Console.WriteLine($"Multiplication: {Calculator.Multiply(a, b)}");
        //    Console.WriteLine($"Division: {Calculator.Divide(a, b)}"); 
            
        //    Console.ReadLine();
        //}
    }

    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}
