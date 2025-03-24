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
        //public static void Main(string[] args)
        //{
        //    //Console.WriteLine("enter text");
        //    //string str = Console.ReadLine();
        //    string str = "Hello World";
        //    int[] arr = new int[] { 1, 2, 3, 4, 5 };

        //    //#region ReverseString - 1.1
        //    //Console.WriteLine("\n1.1 ReverseString - 1");
        //    //ReverseString1(str);
        //    //#endregion 

        //    #region ReverseString - 1.2
        //    Console.WriteLine("\n1.2 ReverseString - 2");
        //    ReverseString2();
        //    #endregion

        //    //#region ReverseString - 1.3
        //    //Console.WriteLine("\n1.3 ReverseString - 3");
        //    //ReverseString3();
        //    //#endregion

        //    //#region chkPalindrome - 2
        //    //Console.WriteLine("\n2. check Palindrome");
        //    //chkPalindrome(str);
        //    //#endregion

        //    #region Countcharacter - 3
        //    Console.WriteLine("\n3. Count character");
        //    /*Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.*/
        //    Countcharacter(str);
        //    #endregion

        //    //#region Countcharacter  - 3.1
        //    //Console.WriteLine("\n3.1 Count character");
        //    ///*Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.*/
        //    //Countcharacter1(str);
        //    //#endregion

        //    #region Get Duplicate character into string

        //    var duplicates = GetDuplicateCharacters(str);
        //    Console.WriteLine("Duplicate characters in {str} are: " + duplicates);
        //    #endregion

        //    #region removeduplicate - 4
        //    Console.WriteLine("\n4. remove duplicate");
        //    /*Ans.: The user will input a string and the method should remove multiple occurrences of characters in the string
        //    input: csharpcorner, output: csharpone*/

        //    removeduplicate(str);
        //    #endregion

        //    //#region Count Vowels and Consonants in a String 5
        //    //Console.WriteLine("\n\n5. Count Vowels and Consonants in a String");
        //    //CountVowels_Consonants();
        //    //#endregion

        //    //#region IsAnagram 6
        //    //Console.WriteLine("\n\n6. string is Anagram or not");
        //    //IsAnagram();
        //    //#endregion

        //    //#region Replace Characters in a String 7

        //    //Console.WriteLine("\n\n7. Replace Characters in a String");
        //    //stringreplacecharacter();
        //    //#endregion

        //    //#region Find the Length of a String 8
        //    //Console.WriteLine("\n\n8. Find the Length of a String");
        //    //lengthofstring();
        //    //#endregion

        //    //#region lower and upper case string 9
        //    //Console.WriteLine("\n\n9. lower and upper case string");
        //    //uppertolower();
        //    //#endregion

        //    //#region split a string 10
        //    //Console.WriteLine("\n\n10. split a string");
        //    //splitintowords();
        //    //#endregion

        //    //#region concanate two string 11
        //    //Console.WriteLine("\n\n11. concanate two string");
        //    //concatnatetwostring();
        //    //#endregion

        //    //#region Check Null Validation 12
        //    //Console.WriteLine("\n\n12. Check Null Validation");
        //    //CheckNullValidation();
        //    //#endregion

        //    //#region Check String Contains 13
        //    //Console.WriteLine("\n\n13 Check String Contains");
        //    //CheckStringContain();
        //    //#endregion

        //    //#region Compare two strings 14
        //    //Console.WriteLine("\n\n14 Compare two strings");
        //    //Comparetwostrings();
        //    //#endregion

        //    //#region Remove white space 15
        //    //Console.WriteLine("\n\n15 Remove white space");
        //    //removewhitespace();
        //    //#endregion

        //    //#region Replace substring 16
        //    //Console.WriteLine("\n\n16 Replace substring");
        //    //replacesubstring();
        //    //#endregion

        //    //#region Replace String To Number 17
        //    //Console.WriteLine("\n\n17 Replace String To Number");
        //    //replaceStringToNumber();
        //    //#endregion

        //    //#region Join array string To String 18
        //    //Console.WriteLine("\n18 Join array string To String");
        //    //joinarraystringToString();
        //    //#endregion

        //    //#region Extract a substring 19
        //    //Console.WriteLine("\n19 Extract a substring");
        //    //extractasubstring();
        //    //#endregion

        //    //#region validate Start End 20
        //    //Console.WriteLine("\n20 validate Start End");
        //    //validateStartEnd();
        //    //#endregion

        //    //#region escape special characters 21
        //    //Console.WriteLine("\n21 escape special characters");
        //    //Escapespecialcharacters();
        //    //#endregion

        //    //#region Format String 22
        //    //Console.WriteLine("\n22 Format String");
        //    //FormatString();
        //    //#endregion

        //    //FormatString();

        //    //#region ReverseWordOrder - 15
        //    //Console.WriteLine("\n15.1. Reverse Word Order 1");
        //    ///*The user will input a sentence and we need to reverse the sequence of words in the sentence.
        //    //input: Welcome to Csharp corner, output: corner Csharp to Welcome*/

        //    //ReverseWordOrder(str);

        //    //Console.WriteLine("\n3.2. Reverse Words Order 2");
        //    //ReverseWords();
        //    //#endregion

        //    //#region ReverseWords - 4
        //    //Console.WriteLine("\n\n4. Reverse Words");
        //    ///*Ans.: The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.
        //    //input: Welcome to Csharp corner, output: emocleW ot prahsC renroc*/

        //    //ReverseWords(str);


        //    //#endregion

        //    // #region findallsubstring - 7
        //    // Console.WriteLine("\n7. find all substring");

        //    // //]m,This is a very frequent interview question.Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.
        //    // //input: abcd , output: a ab abc abcd b bc bcd c cd d*/

        //    //findallsubstring(str);
        //    // #endregion

        //    //#region RotateLeft;
        //    //Console.WriteLine("\n\n8. Rotate Left");
        //    ///*Ans.: The user will input an integer array and the method should shift each element of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.
        //    //input: 1 2 3 4 5, output: 2 3 4 5 1*/

        //    //RotateLeft(arr);
        //    //#endregion







        //    Console.ReadLine();
        //}


        #region All String Program

        internal static void ReverseString1(string str)
        {

            char[] charArray = str.ToCharArray();
            for (i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine("reverse string 1 : " + reversedstring);
        }

        internal static void ReverseString2()
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
            Console.WriteLine("reverse string 2 : " + rev);

            #endregion
        }

        internal static void ReverseString3()
        {
            #region Reverse a string
            //Reverse a string
            //Solution.Here, we have to reverse a string. For example, if we pass a string as "hello," then the output should be "olleh". For reversing the string, first, we will check the string should not be null or empty. After that, we will loop on the string from the secondlast index (length- 1)and the output will be added into another string object, "result".
            string input = "Hello Sanjay";
            char[] strArray = input.ToCharArray();
            Array.Reverse(strArray);
            string NewString = new string(strArray);
            Console.WriteLine("reverse string 3 : " + NewString);
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

        internal static void ReverseWordOrder1(string str)
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

        internal static void ReverseWordOrder2(string str)
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

        internal static void ReverseWordOrder3()
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
                    if (characterCount.ContainsKey(character))
                    {
                        characterCount[character]++;
                    }
                    else
                    {
                        characterCount[character] = 1;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        internal static void Countcharacter1(string str)
        {
            string strcountcharacter = "banana";
            int count = strcountcharacter.Count(c => c == 'a');
            Console.WriteLine(count);
        }

        internal static StringBuilder GetDuplicateCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            HashSet<char> seenChars = new HashSet<char>();

            foreach (char item in input)
            {
                if (!seenChars.Contains(char.ToLower(item)))
                {
                    seenChars.Add(char.ToLower(item));
                }
                else if (result.ToString().IndexOf(char.ToLower(item)) == -1)
                {
                    result.Append(item);
                }
            }
            return result;
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
            int vowels = 0, consonants = 0;
            foreach (char c in str1.ToLower())
            {
                if ("aeiou".Contains(c))
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
        }

        internal static void CheckNullValidation()
        {
            string str1 = "";
            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("string is null or empty");
            }
        }

        internal static void CheckStringContain()
        {
            string str1 = "Hello Sanjay";
            if (str1.Contains("Sanjay"))
            {
                Console.WriteLine("substring found !!");
            }
        }

        internal static void Comparetwostrings()
        {
            string str1 = "Sanjay";
            string str2 = "sanjay";
            bool check = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(check);
        }

        internal static void removewhitespace()
        {
            string str1 = " Hello Sanjay ";
            string trimmed = str1.Trim();
            Console.WriteLine(trimmed);
        }

        #endregion



        internal static void replacesubstring()
        {
            string str1 = "Hello Sanjay ";
            string replace = str1.Replace("Sanjay", "Kanchan");
            Console.WriteLine(replace);
        }

        internal static void replaceStringToNumber()
        {
            string strnum = "123";
            int num = int.Parse(strnum);
            string invalid = "abc";
            bool valid = int.TryParse(invalid, out int result);
            Console.WriteLine(num);
            Console.WriteLine(valid);
        }

        internal static void joinarraystringToString()
        {
            string[] strArr = { "Hello", "Sanjay", "!" };

            string strJoin = string.Join(" ", strArr);
            Console.WriteLine(strJoin);
        }
        internal static void extractasubstring()
        {
            string str = "Hello Sanjay How are you?";

            string substr = str.Substring(6, 6);
            Console.WriteLine(substr);
        }

        internal static void validateStartEnd()
        {
            string str = "Hello Sanjay";

            bool startWith = str.StartsWith("Hello");
            bool endWith = str.EndsWith("Sanjay");
            Console.WriteLine(startWith);
            Console.WriteLine(endWith);
        }
        internal static void Escapespecialcharacters()
        {
            string strEscapespecialcharacters = "He said, \"Hello!\"";
            Console.WriteLine(strEscapespecialcharacters);
           
        }
        internal static void FormatString()
        {
            string name = "Sanjay";
            int age = 40;
            Console.WriteLine("Name : {0}, Age : {1}", name, age);
            Console.WriteLine($"Name : {name}, Age : {age}");

        }

       

    }

}
