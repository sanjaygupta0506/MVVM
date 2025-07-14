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
        public static void Main(string[] args)
        {
            string input = "aabbcccaab";
            string result = "";
            int i = 0;
            #region Display Prime Number
            //Console.Write("\n1 Display Prime Number : ");
            //Console.Write("Enter the Number : ");
            //int endNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Prime Numbers between 1 to {endNumber} are : ");
            //for (int i = 1; i <= endNumber; i++)
            //{
            //    int counter = 0;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            counter++;
            //            break;
            //        }
            //    }

            //    if (counter == 0 && i != 1)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Check Number is Prime of Not
            //Console.Write("Enter a Number : ");
            //int number = int.Parse(Console.ReadLine());
            //bool IsPrime = true;
            //for (int i = 2; i < number / 2; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        IsPrime = false;
            //        break;
            //    }
            //}
            //if (IsPrime)
            //{
            //    Console.Write("Number is Prime.");
            //}
            //else
            //{
            //    Console.Write("Number is not Prime.");
            //}
            #endregion

            #region String Pattern input - aabbcccaab output - 2a2b3c2a1b

            //while (i < input.Length)
            //{
            //    int count = 0;
            //    char character = input[i];
            //    for (int j = i; j < input.Length; j++)
            //    {
            //        if (character != input[j])
            //        {
            //            break;
            //        }
            //        i = j + 1;
            //        count++;
            //    }
            //    result += count.ToString() + character;
            //}
            //Console.WriteLine(result);
            #endregion

            #region String Pattern input - aabbcccaab output - a - 4, b - 3, c - 3
            //Dictionary<char, int> charcount = new Dictionary<char, int>();
            //foreach (var item in input)
            //{
            //    if (charcount.ContainsKey(item))
            //        charcount[item]++;
            //    else
            //        charcount[item] = 1;
            //}

            //foreach (var a in charcount)
            //{
            //    result = a.Key + " - " + a.Value;
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Swap two numbers without using a third variable
            int a = 10;
            int b = 5;
            a = a + b;  //15
            b = a - b;  // 10
            a = a - b; // 5
            Console.WriteLine("Value of A : " + a + " and " + "Value of B : " + b);
            #endregion

            #region Find No is Even or Odd
            int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            #endregion

            #region check if a string is a palindrome
            string main = "madam";
            string rev = new string(main.Reverse().ToArray());
            if (main == rev)
            {
                Console.WriteLine("String is Palindrone");
            }
            else
            {
                Console.WriteLine("String is Not Palindrone");
            }
            #endregion

            #region CompressString

            StringBuilder resultcompress = new StringBuilder();
            int count = 1;

            for (int s = 1; s < input.Length; s++)
            {
                if (input[s] == input[s - 1])
                {
                    count++;
                }
                else
                {
                    resultcompress.Append(input[s - 1]);
                    resultcompress.Append(count);
                    count = 1;
                }
            }

            //result.Append(input[^1]);
            resultcompress.Append(count.ToString());

            Console.WriteLine($"Compressed output: {resultcompress}");
            #endregion
            Console.ReadLine();
        }

       

        

        

        
        

        

        

      
    }
}
