using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramMain
{
    
    class Program
    {
        // Delegate definition
        public delegate int Operation(int x, int y);

        public static void Main(string[] args)
        {
            

            
           

            //-----------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            int vowelCount = CountVowels(input);
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
            Console.ReadLine();
            //-----------------------------------------------------------------------------------------------------------------//

            // Create delegate instances for each operation
            Operation add = Sum;
            Operation subtract = Difference;
            Operation multiply = Product;

            // Get user input
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Perform operations using delegates
            Console.WriteLine($"Sum: {add(num1, num2)}");
            Console.WriteLine($"Difference: {subtract(num1, num2)}");
            Console.WriteLine($"Product: {multiply(num1, num2)}");
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------------------//


        }



        #region Write a program to count the number of vowels in a given string. The program should ask the user to input the string and then display the number of vowels in the string. Make sure that the program is case-sensitive.

        //Q2.
        public static int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;

            foreach (char c in input)
            {
                if (Array.Exists(vowels, v => v == c))
                {
                    count++;
                }
            }

            return count;
        }

        #endregion

        #region Write a C# program illustrating the use of delegates to calculate SUM, DIFFERENCE and PRODUCT of two integers.
        // Method for addition
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        // Method for subtraction
        public static int Difference(int x, int y)
        {
            return x - y;
        }

        // Method for multiplication
        public static int Product(int x, int y)
        {
            return x * y;
        }

        #endregion

        
    }


}

