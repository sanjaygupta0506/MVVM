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

        //public static void Main(string[] args)
        //{
        //    #region Rotation of Array

        //    int[] arr = new int[] { 11, 14, 2, 5, 1 };
        //    int position = 0, k = 0;
        //    Console.Write("Original Array : ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //    Console.Write("Enter position of rotation : ");
        //    position = Convert.ToInt32(Console.ReadLine());
        //    Program arraySample = new Program();
        //    while (k < position)
        //    {
        //        arraySample.LeftRotate(arr);
        //        k++;
        //    }
        //    Console.WriteLine("Rotation of array by position " + position);
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.ReadLine();

        //    #endregion

        //    #region Max Number in Array

        //    int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
        //    int max = array[0];
        //    int min = array[0];
        //    for (int i = 0; i <= array.Length - 1; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }
        //    }
        //    Console.WriteLine(max);
        //    Console.WriteLine(min);

        //    int[] arr1 = { 8, 3, 5, -1, 2 };
        //    Console.WriteLine("Minimum number is " + arr1.Min());
        //    Console.WriteLine("Maximum number is " + arr1.Max());
        //    Console.Read();
        //    #endregion
        //    //------------------------------------------------------------------------------------------------------------//
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    int sumOfEvens = SumOfEvenNumbers(numbers);
        //    Console.WriteLine($"Sum of even numbers: {sumOfEvens}");
        //    Console.ReadLine();

        //    //-----------------------------------------------------------------------------------------------------------------//
        //    Console.WriteLine("Enter a string:");
        //    string input = Console.ReadLine();
        //    int vowelCount = CountVowels(input);
        //    Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        //    Console.ReadLine();
        //    //-----------------------------------------------------------------------------------------------------------------//
            
        //    // Create delegate instances for each operation
        //    Operation add = Sum;
        //    Operation subtract = Difference;
        //    Operation multiply = Product;

        //    // Get user input
        //    Console.WriteLine("Enter the first number:");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the second number:");
        //    int num2 = int.Parse(Console.ReadLine());

        //    // Perform operations using delegates
        //    Console.WriteLine($"Sum: {add(num1, num2)}");
        //    Console.WriteLine($"Difference: {subtract(num1, num2)}");
        //    Console.WriteLine($"Product: {multiply(num1, num2)}");
        //    Console.ReadLine();

        //    //-----------------------------------------------------------------------------------------------------------------//


        //}

        #region Given an array of integers, write a C# method using lambda expressions to calculate sum of all even numbers. 

        public static int SumOfEvenNumbers(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum();
        }
        #endregion

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

        #region Rotation of Array

        void LeftRotate(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }
        #endregion
    }


}

