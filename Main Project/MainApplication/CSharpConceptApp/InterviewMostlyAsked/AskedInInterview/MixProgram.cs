using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterviewProgramMain
{

    //class Program
    //{
    //    // Delegate definition
    //    public delegate int Operation(int x, int y);

    //    //public static void Main(string[] args)
    //    //{

    //    //    //-----------------------------------------------------------------------------------------------------------------//
    //    //    //Console.WriteLine("Enter a string:");
    //    //    //string input = Console.ReadLine();
    //    //    //int vowelCount = CountVowels(input);
    //    //    //Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
    //    //    //Console.ReadLine();
    //    //    //-----------------------------------------------------------------------------------------------------------------//

    //    //    // Create delegate instances for each operation
    //    //    //Operation add = Sum;
    //    //    //Operation subtract = Difference;
    //    //    //Operation multiply = Product;

    //    //    //// Get user input
    //    //    //Console.WriteLine("Enter the first number:");
    //    //    //int num1 = int.Parse(Console.ReadLine());

    //    //    //Console.WriteLine("Enter the second number:");
    //    //    //int num2 = int.Parse(Console.ReadLine());

    //    //    //// Perform operations using delegates
    //    //    //Console.WriteLine($"Sum: {add(num1, num2)}");
    //    //    //Console.WriteLine($"Difference: {subtract(num1, num2)}");
    //    //    //Console.WriteLine($"Product: {multiply(num1, num2)}");
    //    //    //Console.ReadLine();

    //    //    //-----------------------------------------------------------------------------------------------------------------//

    //    //    //Coforge();
    //    //    //Coforge2();
    //    //    RevString();
    //    //    ReverseWordOrder1();

    //    //}






    //    #region Write a program to count the number of vowels in a given string. The program should ask the user to input the string and then display the number of vowels in the string. Make sure that the program is case-sensitive.

    //    //Q2.
    //    public static int CountVowels(string input)
    //    {
    //        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    //        int count = 0;

    //        foreach (char c in input)
    //        {
    //            if (Array.Exists(vowels, v => v == c))
    //            {
    //                count++;
    //            }
    //        }

    //        return count;
    //    }

    //    #endregion

    //    #region Write a C# program illustrating the use of delegates to calculate SUM, DIFFERENCE and PRODUCT of two integers.
    //    // Method for addition
    //    public static int Sum(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    // Method for subtraction
    //    public static int Difference(int x, int y)
    //    {
    //        return x - y;
    //    }

    //    // Method for multiplication
    //    public static int Product(int x, int y)
    //    {
    //        return x * y;
    //    }

    //    #endregion

    //    public static void Coforge()
    //    {
    //        string input = "this is sanjay";
    //        string[] words = input.Split(' ');

    //        for (int i = 0; i < words.Length; i++)
    //        {
    //            // Reverse words at odd positions (1-based index)
    //            if (i % 2 == 0)
    //            {
    //                char[] chars = words[i].ToCharArray();
    //                Array.Reverse(chars);
    //                words[i] = new string(chars);
    //            }
    //        }

    //        string result = string.Join(" ", words);
    //        Console.WriteLine(result);
    //        Console.ReadLine();
    //    }

    //    public static void Coforge2()
    //    {
    //        object[] input = { 1, 4, 2, "d", 4, 3, 6, "e", 4, 2, 9, 6 };
    //        List<object> result = new List<object>();
    //        List<int> numbers = new List<int>();

    //        foreach (var item in input)
    //        {
    //            if (item is int)
    //            {
    //                numbers.Add((int)item);
    //            }
    //            else
    //            {
    //                // Sort numbers before string
    //                numbers.Sort();
    //                result.AddRange(numbers.Cast<object>());
    //                numbers.Clear();

    //                // Add string as-is
    //                result.Add(item);
    //            }
    //        }

    //        // Sort remaining numbers after last string
    //        numbers.Sort();
    //        result.AddRange(numbers.Cast<object>());

    //        // Print output
    //        Console.WriteLine($"[{string.Join(",", result)}]");
    //        Console.ReadLine();
    //    }

    //    public static void RevString()
    //    {
    //        string strinput = "sanjay";
    //        string strrev = string.Empty;


    //        try
    //        {
    //            for (int i = strinput.Length - 1; i >= 0; i--)
    //            {
    //                strrev = strrev + strinput[i];

    //            }
    //            Console.WriteLine("reverse string - " + strrev);

    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //    }

    //    public static void ReverseWordOrder1()
    //    {
    //        string strSanjay = "my name is sanjay and my place name is faridabad";
    //        #region Reverse Word Order - 26.1

    //        StringBuilder reverseSentence = new StringBuilder();
    //        int i;
    //        int Start = strSanjay.Length - 1;
    //        int End = strSanjay.Length - 1;

    //        while (Start > 0)
    //        {
    //            if (strSanjay[Start] == ' ')
    //            {
    //                i = Start + 1;
    //                while (i <= End)
    //                {
    //                    reverseSentence.Append(strSanjay[i]);
    //                    i++;
    //                }
    //                reverseSentence.Append(' ');
    //                End = Start - 1;
    //            }
    //            Start--;
    //        }

    //        for (i = 0; i <= End; i++)
    //        {
    //            reverseSentence.Append(strSanjay[i]);
    //        }
    //        Console.WriteLine(reverseSentence.ToString());
    //        Console.ReadLine();
    //        #endregion
    //    }


    //}

    public sealed class Calculator
    {
        private static Calculator instance = null;
        public static int counter = 0;

        private Calculator()
        {
            counter++;
        }

        public static Calculator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculator();
                }
                return instance;
            }
        }

        public void Print()
        {
            Console.WriteLine("SingleTon Example");
        }

        public double Value1 { get; set; }
        public double Value2 { get; set; }

        //public static void Main(string[] args)
        //{
        //    Calculator.Instance.Value1 = 10;
        //    Calculator.Instance.Value2 = 5;
        //    Calculator.Instance.Add();
        //    Calculator.Instance.Print();
            
        //    Console.WriteLine(counter.ToString());
        //    Console.ReadLine();
        //}

        public void Add()
        {
            double Sum = Value1 + Value2;
            Console.WriteLine(Sum.ToString());
            Console.ReadLine();
        }

    }

}


