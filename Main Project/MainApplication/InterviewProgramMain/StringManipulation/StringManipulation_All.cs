using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLogicalProgram.StringManipulation
{
    public class StringManipulation_All
    {
        private static int i;
        private static int j;
        public static void Main(string[] args)
        {
            //Console.WriteLine("enter text");
            //string str = Console.ReadLine();
            string str = "Hello World";
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            #region ReverseString - 1
            Console.WriteLine("\n1. ReverseString - 1");
            /*The user will input a string and the method should return the reverse of that string
            input: hello, output: olleh
            input: hello world, output: dlrow olleh*/

            ReverseString(str);
            Console.WriteLine("\n1. ReverseString - 2");
            ReverseString();
            #endregion

            #region chkPalindrome - 2
            Console.WriteLine("\n2. check Palindrome");
            /*Ans.: The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not.

            input: madam, output: Palindrome
            input: step on no pets, output: Palindrome
            input: book, output: Not Palindrome
            if we pass an integer as a string parameter then also this method will give the correct output

            input: 1221, output: Palindrome*/

            chkPalindrome(str);
            #endregion

            #region Countcharacter - 3
            Console.WriteLine("\n3. Count character");
            /*Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

            input: hello world;
            output: 
            h – 1
            e – 1
            l – 3
            o – 2
            w – 1
            r – 1
            d – 1*/

            Countcharacter(str);
            #endregion

            #region removeduplicate - 4
            Console.WriteLine("\n4. remove duplicate");
            /*Ans.: The user will input a string and the method should remove multiple occurrences of characters in the string
            input: csharpcorner, output: csharpone*/

            removeduplicate(str);
            #endregion

            #region Count Vowels and Consonants in a String 5
            Console.WriteLine("\n\n5. Count Vowels and Consonants in a String");
            CountVowels_Consonants();
            #endregion

            #region IsAnagram 6
            Console.WriteLine("\n\n6. string is Anagram or not");
            IsAnagram();
            #endregion

            #region Replace Characters in a String 7

            Console.WriteLine("\n\n7. Replace Characters in a String");
            stringreplacecharacter();
            #endregion

            #region Find the Length of a String 8
            Console.WriteLine("\n\n8. Find the Length of a String");
            lengthofstring();
            #endregion

            #region lower and upper case string 9
            Console.WriteLine("\n\n9. lower and upper case string");
            uppertolower();
            #endregion

            #region split a string 10
            Console.WriteLine("\n\n10. split a string");
            splitintowords();
            #endregion

            #region concanate two string
            Console.WriteLine("\n\n11. concanate two string");
            concatnatetwostring();
            #endregion



            #region ReverseWordOrder - 15
            Console.WriteLine("\n15.1. Reverse Word Order 1");
            /*The user will input a sentence and we need to reverse the sequence of words in the sentence.
            input: Welcome to Csharp corner, output: corner Csharp to Welcome*/

            ReverseWordOrder(str);

            Console.WriteLine("\n3.2. Reverse Words Order 2");
            ReverseWords();
            #endregion

            #region ReverseWords - 4
            Console.WriteLine("\n\n4. Reverse Words");
            /*Ans.: The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.
            input: Welcome to Csharp corner, output: emocleW ot prahsC renroc*/

            ReverseWords(str);


            #endregion

            #region findallsubstring - 7
            Console.WriteLine("\n7. find all substring");
            /*Ans.: This is a very frequent interview question. Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.
            input: abcd , output : a ab abc abcd b bc bcd c cd d*/

            findallsubstring(str);
            #endregion

            #region RotateLeft;
            Console.WriteLine("\n\n8. Rotate Left");
            /*Ans.: The user will input an integer array and the method should shift each element of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.
            input: 1 2 3 4 5, output: 2 3 4 5 1*/

            RotateLeft(arr);
            #endregion

            

           

            

            Console.ReadLine();
        }

        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        internal static void ReverseString()
        {
            #region Reverse a string
            //Reverse a string
            //Solution.Here, we have to reverse a string. For example, if we pass a string as "hello," then the output should be "olleh". For reversing the string, first, we will check the string should not be null or empty. After that, we will loop on the string from the secondlast index (length- 1)and the output will be added into another string object, "result".
            string input = "Hello Sanjay";
            string rev = string.Empty;
            for (i = input.Length - 1; i >= 0; i--)
            {
                rev = rev + input[i];
            }
            Console.WriteLine("reverse string : " + rev);

            #endregion
        }

        internal static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        internal static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }

        internal static void ReverseWords(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
        }

        internal static void ReverseWords()
        {
            #region Reverse Each Word

            string s = "Hello Sanjay";
            string[] words = s.Split(' ');
            //Console.WriteLine("\nRevese order of the given words :");
            for (i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            #endregion
        }

        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }

        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        internal static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        internal static void CountVowels_Consonants()
        {
            #region Count Vowels and Consonants in a String

            string str1 = "Hello Sanjay";
            int vowels = 0, consonants=0;
            foreach (char c in str1.ToLower())
            {
                if("aeiou".Contains(c))
                {
                    vowels++;
                }
                else if (char.IsLetter(c))
                {
                    consonants++;
                }
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
            #endregion
        }

        internal static void IsAnagram()
        {
            string str1 = "silent";
            string str2 = "listen";
            bool isAnagram = string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
            Console.WriteLine(isAnagram ? "Anagrams" : "Not Anagrams");
        }

        internal static void stringreplacecharacter()
        {
            string str1 = "Hello World";
            string replace = str1.Replace("l", "s");
            Console.WriteLine(replace); ;
        }

        internal static void lengthofstring()
        {
            string str1 = "Hello World";
            Console.WriteLine($"Length : {str1.Length}");
        }

        internal static void uppertolower()
        {
            string str1 = "Hello World";
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
        }

        internal static void splitintowords()
        {
            string str1 = "Hello Sanjay";
            string[] strword = str1.Split(' ');
            foreach (var item in strword)
            {
                Console.WriteLine(item);
            }
        }

        internal static void concatnatetwostring()
        {
            string str1 = "Hello";
            string str2 = "Sanjay";

            string result = str1 + " " + str2;
            string result1 = string.Concat(str1, " ", str2);
            string result2 = $"{str1} {str2}";
           
            Console.WriteLine(result);
            Console.WriteLine($"Result : {result}");
            Console.WriteLine($"Result1 : {result1}");
            Console.WriteLine($"Result2 : {result2}");

            //string concate = string.Concat(str1 "" + str2)

        }




    }

}
