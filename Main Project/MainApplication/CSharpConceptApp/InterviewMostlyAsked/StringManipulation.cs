using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CShapLogicalProgram.StringManipulation
{
    public class StringManipulation_All
    {
        static int i, j = 0;
        static int count, count1 = 1;
        static string strMain = "Hello World";
        static string strSanjay = "Hello Sanjay";
        static string input = "banana";
        static string result = string.Empty;
        static string replace = string.Empty;
        static string rev = string.Empty;
        static string str11 = "Hello";
        static string str12 = "Sanjay";
        static string result11;
        static string result12;
        static string result13;
        static string strValidate = "";
        static string str21 = "Sanjay";
        static string str22 = "sanjay";
        static StringBuilder result1, sb;
        static int[] arr = new int[] { 1, 2, 3, 4, 5 };
        static int[] array = new int[] { 6, 7, 8, 9, 10 };
        static char[] charArray;
        static HashSet<char> seenChars = new HashSet<char>();
        //public static void Main(string[] args)
        //{
            //    //ReverseString1();
            //    //ReverseString2();
            //    //ReverseString3();

            //    //RemoveDuplicate1();
            //    //RemoveDuplicate2();
            //    //FindDuplicate1();
            //    //FindDuplicate2();
                //IsAnagram();
            //    //CountOccurance();
            //    //CountOccurancewithLINQ1();
            //    //CountOccurancewithLINQ2();
            //    //CountOccurancewithFilter();
            //    SecondHighestCharacterCount();
            //    //chkPalindrome1();
            //    //chkPalindrome2();
        //    Console.WriteLine(FirstNonRepeatingChar("banana"));
        //FirstNonRepeatingChar1();

        //    //StringCompress1();
        //    //StringCompress2();
        //    //CountVowelsandConsonants(); 
        //    //ReplaceCharacters();
        //    //FindLength();
        //    //LowerandUpper();
        //    //splitstring();
        //    //concatenatestring();
        //    //CheckNullValidation();
        //    //CheckStringContains();
        //    //Comparestrings();
        //    //RemoveWhiteSpace();
        //    //ReplaceSubstring();
        //    //ReplaceStringToNumber();
        //    //JoinarraystringToString();
        //    //ExtractSubstring();
        //    //ValidateStartEnd();
        //    //EscapeSpecialCharacters();
        //    //FormatString();
        //    //ReverseWordOrder1();
        //    //ReverseWordOrder2();
        //    //ReverseWordOrder3();
        //    //FindAllSubstring();
        //    //RotateLeft();

        //    Console.ReadLine();
        //}

        public static void ReverseString1()
        {
            #region ReverseString - 1.1
            Console.WriteLine("\n1.1 ReverseString - 1");
            for (i = strSanjay.Length - 1; i >= 0; i--)
            {
                rev = rev + strSanjay[i];
            }
            Console.WriteLine("reverse string 1 : " + rev);
            #endregion
        }
        public static void ReverseString2()
        {
            #region ReverseString - 1.2
            Console.WriteLine("\n1.2 ReverseString - 2");
            charArray = strMain.ToCharArray();
            for (i = 0, j = strMain.Length - 1; i < j; i++, j--)
            {
                charArray[i] = strMain[j];
                charArray[j] = strMain[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine("reverse string 1 : " + reversedstring);
            #endregion
        }
        public static void ReverseString3()
        {
            #region ReverseString - 1.3
            Console.WriteLine("\n1.3 ReverseString - 3");

            char[] strArray = strSanjay.ToCharArray();
            Array.Reverse(strArray);
            string NewString = new string(strArray);
            Console.WriteLine("reverse string 3 : " + NewString);
            #endregion
        }

        public static void CountOccurance()
        {
            #region Count Occurance - 5
            Console.WriteLine("\n5 Count Occurance");
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in strMain)
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
            #endregion
        }
        public static void CountOccurancewithLINQ1()
        {
            #region Count Occurance with LINQ - 5.1
            Console.WriteLine("\n5.1 Count Occurance");

            var output = input.GroupBy(c => c)
                        .ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine(string.Join(" ", output));
            #endregion
        }
        public static void CountOccurancewithLINQ2()
        {
            #region Count Occurance with LINQ - 5.2
            Console.WriteLine("\n5.2 Count Occurance");
            string input1 = "my name is sanjay and my place name is faridabad";
            string[] word = input1.Split(' ');
            var output2 = word.GroupBy(c => c)
                        .ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine(string.Join(" ", output2));
            #endregion
        }
        public static void CountOccurancewithFilter()
        {
            #region Count Occurance with Filter  - 5.4
            Console.WriteLine("\n5.4 Count Occurance with Filter");
            int count = input.Count(c => c == 'a');
            Console.WriteLine(count);
            #endregion
        }

        public static void SecondHighestCharacterCount()
        {
            Console.WriteLine("\n5.4 Second Highest Count Occurance");
            string input = "AABBBBCCCDDDDD";
            Dictionary<char, int> CountOcc = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if(CountOcc.ContainsKey(item))
                {
                    CountOcc[item]++;
                }
                else
                {
                    CountOcc[item] = 1;
                }
            }

            var sorted = CountOcc.OrderByDescending(x => x.Value).ToList();

           
                if (sorted.Count >= 2)
                {
                    var second = sorted[1];
                    Console.WriteLine($"Second most frequent character: {second.Key}, Count: {second.Value}");
                }
           
        }

        public static void FindDuplicate1()
        {
            #region Find Duplicate character into string 3.1
            Console.WriteLine("\n3.1 Get Duplicate character into string");
            result1 = new StringBuilder();
            foreach (char item in input)
            {
                if (!seenChars.Contains(char.ToLower(item)))
                {
                    seenChars.Add(char.ToLower(item));
                }
                else if (result1.ToString().IndexOf(char.ToLower(item)) == -1)
                {
                    result1.Append(item);
                }
            }
            Console.WriteLine("Duplicate characters in {str} are: " + result1);
            #endregion
        }
        public static void FindDuplicate2()
        {
            #region Find Duplicate character into string 3.2
            Console.WriteLine("\n\n3.2. Find Duplicate characters from string");

            var chars = input.ToCharArray();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            //logic
            foreach (var item in chars)
            {
                if (charDictionary.ContainsKey(item))
                    charDictionary[item]++;
                else
                    charDictionary[item] = 1;
            }
            var keys = new HashSet<char>(charDictionary.Keys);
            foreach (var ch in keys)
            {
                if (charDictionary[ch] > 1)
                    Console.WriteLine($"Character {ch} repeating {charDictionary[ch]} times.");
            }
            #endregion
        }

        public static void RemoveDuplicate1()
        {
            #region remove duplicate - 2.1
            Console.WriteLine("\n2.1 remove duplicate");
            for (i = 0; i < strMain.Length; i++)
            {
                if (!result.Contains(strMain[i]))
                {
                    result += strMain[i];
                }
            }
            Console.WriteLine(result);
            #endregion
        }
        public static void RemoveDuplicate2()
        {
            #region remove duplicate - 2.2
            Console.WriteLine("\n2.2 remove duplicate");
            HashSet<char> seen = new HashSet<char>();
            sb = new StringBuilder();
            foreach (char c in input)
            {
                if (seen.Add(c))
                    sb.Append(c);
            }
            Console.WriteLine(sb.ToString());

            #endregion
        }
        
        public static void IsAnagram()
        {
            #region IsAnagram 4
            Console.WriteLine("\n\n4. string is Anagram or not");
            string str1 = "silent";
            string str2 = "listen";
            bool isAnagram = string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
            Console.WriteLine(isAnagram ? "Anagrams" : "Not Anagrams");
            #endregion
        }

        public static char FirstNonRepeatingChar(string input)
        {
            #region First Non Repeating Char - 6
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            foreach (var c in input)
            {
                if (charCount[c] == 1)
                    return c;
            }
            return '\0';
            #endregion
        }
        public static void FirstNonRepeatingChar1()
        {
            #region First Non Repeating Char - 6.1
            Console.WriteLine("\n6 First Non Repeating Char");
            var output5 = strMain.GroupBy(c => c)
                        .Where(g => g.Count() == 1)
                        .Select(g => g.Key)
                        .FirstOrDefault();

            Console.WriteLine(string.Join(" ", output5));
            #endregion
        }

        public static void chkPalindrome1()
        {
            #region chkPalindrome - 7.1
            Console.WriteLine("\n7.1 check Palindrome");
            bool flag = false;
            for (i = 0, j = strMain.Length - 1; i < strMain.Length / 2; i++, j--)
            {
                if (strMain[i] != strMain[j])
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
            #endregion

        }
        public static void chkPalindrome2()
        {
            #region check Palindrome- 7.2
            Console.WriteLine("\n7.2 check Palindrome");
            string main = "madam";
            string rev1 = new string(main.Reverse().ToArray());
            if (main == rev1)
            {
                Console.WriteLine("String is Palindrone");
            }
            else
            {
                Console.WriteLine("String is Not Palindrone");
            }
            #endregion
        }

       

        public static void StringCompress1()
        {
            #region String Compress - 8.1
            Console.WriteLine("\n8.1 String Compress");

            sb = new StringBuilder();
            char current = input[0];
            for (i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                    count++;
                else
                {
                    sb.Append(current).Append(count1);
                    current = input[i];
                    count = 1;
                }
            }
            sb.Append(current).Append(count1);
            Console.WriteLine(sb.ToString());
            #endregion
        }
        public static void StringCompress2()
        {
            #region String Compress - 8.2
            Console.WriteLine("\n8.2 String Compress");

            StringBuilder resultcompress = new StringBuilder();
            int count5 = 1;

            for (int s1 = 1; s1 < input.Length; s1++)
            {
                if (input[s1] == input[s1 - 1])
                {
                    count5++;
                }
                else
                {
                    resultcompress.Append(input[s1 - 1]);
                    resultcompress.Append(count5);
                    count5 = 1;
                }
            }

            //result.Append(input[^1]);
            resultcompress.Append(count5.ToString());

            Console.WriteLine($"Compressed output: {resultcompress}");

            #endregion
        }

        public static void CountVowelsandConsonants()
        {
            #region Count Vowels and Consonants in a String 9
            Console.WriteLine("\n\n9. Count Vowels and Consonants in a String");
            int vowels = 0, consonants = 0;
            foreach (char c in strSanjay.ToLower())
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
        public static void ReplaceCharacters()
        {
            #region Replace Characters in a String 10

            Console.WriteLine("\n\n10. Replace Characters in a String");
            replace = strMain.Replace("l", "s");
            Console.WriteLine(replace); ;
            #endregion
        }
        public static void FindLength()
        {
            #region Find the Length of a String 11
            Console.WriteLine("\n\n11. Find the Length of a String");
            Console.WriteLine($"Length : {strMain.Length}");
            #endregion
        }
        public static void LowerandUpper()
        {
            #region lower and upper case string 12
            Console.WriteLine("\n\n12. lower and upper case string");
            Console.WriteLine(strMain.ToUpper());
            Console.WriteLine(strMain.ToLower());
            #endregion
        }
        public static void splitstring ()
        {
            #region split a string 13
            Console.WriteLine("\n\n13. split a string");

            string[] strword = strMain.Split(' ');
            foreach (var item in strword)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        public static void concatenatestring ()
        {
            #region concatenate two string 14
            Console.WriteLine("\n\n14. concanate two string");
            result11 = str11 + " " + str12;
            result12 = string.Concat(str11, " ", str12);
            result13 = $"{str11} {str12}";

            Console.WriteLine(result11);
            Console.WriteLine($"Result : {result11}");
            Console.WriteLine($"Result1 : {result12}");
            Console.WriteLine($"Result2 : {result13}");
            #endregion

        }
        public static void CheckNullValidation()
        {
            #region Check Null Validation 15
            Console.WriteLine("\n\n15. Check Null Validation");

            if (string.IsNullOrEmpty(strValidate))
            {
                Console.WriteLine("string is null or empty");
            }
            #endregion
        }
        public static void CheckStringContains()
        {
            #region Check String Contains 16
            Console.WriteLine("\n\n16 Check String Contains");
            if (strSanjay.Contains("Sanjay"))
            {
                Console.WriteLine("substring found !!");
            }
            #endregion
        }
        public static void Comparestrings()
        {
            #region Compare two strings 17
            Console.WriteLine("\n\n17 Compare two strings");

            bool check = str21.Equals(str22, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(check);
            #endregion
        }
        public static void RemoveWhiteSpace()
        {
            #region Remove white space 18
            Console.WriteLine("\n\n18 Remove white space");
            string trimmed = strSanjay.Trim();
            Console.WriteLine(trimmed);
            #endregion
        }
        public static void ReplaceSubstring()
        {
            #region Replace substring 19
            Console.WriteLine("\n\n19 Replace substring");
            replace = strSanjay.Replace("Sanjay", "Kanchan");
            Console.WriteLine(replace);
            #endregion
        }
        public static void ReplaceStringToNumber()
        {
            #region Replace String To Number 20
            Console.WriteLine("\n\n20 Replace String To Number");
            string strnum = "123";
            int num = int.Parse(strnum);
            string invalid = "abc";
            bool valid = int.TryParse(invalid, out int result2);
            Console.WriteLine(num);
            Console.WriteLine(valid);
            #endregion

        }
        public static void JoinarraystringToString()
        {
            #region Join array string To String 21
            Console.WriteLine("\n21 Join array string To String");
            string[] strArr = { "Hello", "Sanjay", "!" };

            string strJoin = string.Join(" ", strArr);
            Console.WriteLine(strJoin);
            #endregion
        }
        public static void ExtractSubstring()
        {
            #region Extract a substring 22
            Console.WriteLine("\n22 Extract a substring");
            string Exstr = "Hello Sanjay How are you?";

            string substr = Exstr.Substring(6, 6);
            Console.WriteLine(substr);
            #endregion
        }
        public static void ValidateStartEnd()
        {
            #region validate Start End 23
            Console.WriteLine("\n23 validate Start End");

            bool startWith = strSanjay.StartsWith("Hello");
            bool endWith = strSanjay.EndsWith("Sanjay");
            Console.WriteLine(startWith);
            Console.WriteLine(endWith);
            #endregion
        }
        public static void EscapeSpecialCharacters()
        {
            #region escape special characters 24
            Console.WriteLine("\n24 escape special characters");
            string strEscapespecialcharacters = "He said, \"Hello!\"";
            Console.WriteLine(strEscapespecialcharacters);
            #endregion
        }
        public static void FormatString()
        {
            #region Format String 25
            Console.WriteLine("\n25 Format String");
            string name = "Sanjay";
            int age = 40;
            Console.WriteLine("Name : {0}, Age : {1}", name, age);
            Console.WriteLine($"Name : {name}, Age : {age}");
            #endregion
        }
        public static void ReverseWordOrder1()
        {
            #region Reverse Word Order - 26.1
            Console.WriteLine("\n26.1. Reverse Word Order 1");

            StringBuilder reverseSentence = new StringBuilder();

            int Start = strSanjay.Length - 1;
            int End = strSanjay.Length - 1;

            while (Start > 0)
            {
                if (strSanjay[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(strSanjay[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(strSanjay[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
            #endregion
        }
        public static void ReverseWordOrder2()
        {
            #region  Reverse Word Order 26.2);
            Console.WriteLine("\n26.2. Reverse Words Order 15.2");
            StringBuilder output3 = new StringBuilder();
            List<char> charlist = new List<char>();

            for (i = 0; i < strSanjay.Length; i++)
            {
                if (strSanjay[i] == ' ' || i == strSanjay.Length - 1)
                {
                    if (i == strSanjay.Length - 1)
                        charlist.Add(strSanjay[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output3.Append(charlist[j]);

                    output3.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(strSanjay[i]);
            }
            Console.WriteLine(output3.ToString());
            #endregion
        }
        public static void ReverseWordOrder3()
        {
            #region Reverse Words Order 26.3
            Console.WriteLine("\n26.3. Reverse Words Order");
            string s = "Hello Sanjay";
            string[] words = s.Split(' ');
            //Console.WriteLine("\nRevese order of the given words :");
            for (i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            #endregion
        }
        public static void FindAllSubstring()
        {
            #region find all substring - 27
            Console.WriteLine("\n27. find all substring");

            for (i = 0; i < strSanjay.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(strSanjay.Length - i);
                for (int j = i; j < strSanjay.Length; ++j)
                {
                    subString.Append(strSanjay[j]);
                    Console.Write(subString + " ");
                }
            }
            #endregion
        }
        public static void RotateLeft()
        {
            #region Rotate Left 28;
            Console.WriteLine("\n\n28. Rotate Left");
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num1 in array)
            {
                Console.Write(num1 + " ");
            }
            #endregion
        }
    }
}

