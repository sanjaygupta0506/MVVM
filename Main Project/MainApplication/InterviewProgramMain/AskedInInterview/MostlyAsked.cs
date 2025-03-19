using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramMain.AskedInInterview
{
    public class MostlyAsked
    {
        private static Random random = new Random();
        //public static void Main(string[] args)
        //{
        //    //string input = "abbcccdddd";
        //    countcharacter();

        //    //string compressed = CompressString(input);
        //    //Console.WriteLine($"Compressed output: {compressed}");

        //    //SwapTwoVarible();
        //    //EvenOrOdd();
        //    //CheckPalindrone();
        //    //Console.WriteLine(IsPrime(11));
        //    //Console.WriteLine(IsFactorial(5)); // Output: 120

        //    Console.ReadLine();
        //}

        #region 1. How do you swap two numbers without using a third variable?
        public static void SwapTwoVarible()
        {
            int a = 10;
            int b = 5;
            a = a + b;  //15
            b = a - b;  // 10
            a = a - b; // 5
            Console.WriteLine("Value of A : " + a + " and " + "Value of B : " + b);
            //Console.ReadLine();
        }
        #endregion



        public static void EvenOrOdd()
        {
            int num = 11;
            if(num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            //Console.ReadLine();

        }


        #region 3. How do you check if a string is a palindrome?

        public static void  CheckPalindrone()
        {
            string main = "madam";
            string rev = new string(main.Reverse().ToArray());
            if(main == rev)
            {
                Console.WriteLine("String is Palindrone");
            }
            else
            {
                Console.WriteLine("String is Not Palindrone");
            }

            //Console.ReadLine();
        }
        #endregion

        #region 5. How do you check if a number is prime?
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        #endregion

        #region 6. How do you find the factorial of a number using recursion?

        static int IsFactorial(int num)
        {
            if (num == 0) return 1;
            return num * IsFactorial(num - 1);
        }
        #endregion

        #region Count Chararcter
        static void countcharacter()
        {
            string input = "abbcccaaaa";
            string result;
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (charcount.ContainsKey(item))
                    charcount[item]++;
                else
                    charcount[item] = 1;
            }

            foreach (var a in charcount)
            {
                result = a.Key + " - " + a.Value;
                Console.WriteLine(result);
            }
            


        }

       
        #endregion

        static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            StringBuilder result = new StringBuilder();
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    result.Append(input[i - 1]);
                    result.Append(count);
                    count = 1;
                }
            }

            //result.Append(input[^1]);
            result.Append(count);

            return result.ToString();
        }
    }
}
