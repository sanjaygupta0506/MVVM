using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramMain.AskedInInterview
{
    public class MostlyAsked
    {
        private static int patterncount = 0;
        private static Random random = new Random();
        static int i;static int j;

        //public static void Main(string[] args)
        //{

        //    DisplayPrimeNumber();
        //    CheckPrimeNumber();
        //    StringPattern1();
        //    StringPattern2();
        //    SwapTwoNumber();
        //    EvenOrOdd();
        //    FirstFactorial();
        //    FizzBuzz();

        //    Console.ReadLine();
        //}

        public static void DisplayPrimeNumber()
        {
            #region 1. Display Prime Number
            Console.Write("\n1 Display Prime Number : ");
            Console.Write("Enter the Number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between 1 to {endNumber} are : ");
            for (i = 1; i <= endNumber; i++)
            {
                int counter = 0;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
            #endregion
        }

        public static void CheckPrimeNumber()
        {
            int cpn = 0;
            #region 2. Check Number is Prime of Not
            Console.Write("\n2 Check Number is Prime of Not ");
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for ( cpn = 2; cpn < number / 2; cpn++)
            {
                if (number % cpn == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
            #endregion
        }
        public static void StringPattern1()
        {
            string input = "aabbcccaab";
            int sp = 0;
            string result = "";
            #region 3.1 String Pattern input - aabbcccaab output - 2a2b3c2a1b
            Console.Write("\n3.1 String Pattern input - aabbcccaab output - 2a2b3c2a1b ");
            while (sp < input.Length)
            {
                char character = input[sp];
                for (int j = sp; j < input.Length; j++)
                {
                    if (character != input[j])
                    {
                        break;
                    }
                    sp = j + 1;
                    patterncount++;
                }
                result += patterncount.ToString() + character;
            }
            Console.WriteLine(result);
            #endregion
        }
        public static void StringPattern2()
        {
            string spinput2 = "";
            string spresult2 = "";

            #region 3.2 String Pattern input - aabbcccaab output - a - 4, b - 3, c - 3
            Console.Write("\n3.2 String Pattern input - aabbcccaab output - a - 4, b - 3, c - 3 ");
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            foreach (var item in spinput2)
            {
                if (charcount.ContainsKey(item))
                    charcount[item]++;
                else
                    charcount[item] = 1;
            }

            foreach (var a1 in charcount)
            {
                spresult2 = a1.Key + " - " + a1.Value;
                Console.WriteLine(spresult2);
            }
            #endregion
        }

        public static void SwapTwoNumber()
        {
            #region 4. Swap two numbers without using a third variable
            Console.Write("\n4 Swap two numbers without using a third variable");
            int a = 10;
            int b = 5;
            a = a + b;  //15
            b = a - b;  // 10
            a = a - b; // 5
            Console.WriteLine("Value of A : " + a + " and " + "Value of B : " + b);
            #endregion
        }

        public static void EvenOrOdd()
        {
            #region 5. Find No is Even or Odd
            Console.Write("\n5 Find No is Even or Odd");
            int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("\nNumber is Even");
            }
            else
            {
                Console.WriteLine("\nNumber is Odd");
            }
            #endregion
        }

        public static long FirstFactorial()
        {
            Console.Write("Enter the Number : ");
            int FacNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Factorial number of {FacNumber} is : ");
            if (FacNumber == 0)
            {
                return 1; // Factorial of 0 is 1
            }

            long result = 1;
            for (int i = 1; i <= FacNumber; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void FizzBuzz()
        {
            //Print numbers 1–100.For multiples of 3 print "Fizz", multiples of 5 print "Buzz", multiples of both print "FizzBuzz".
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

        }













    }
}
