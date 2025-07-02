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
        private static int i;
        private static int j;
        public static void Main(string[] args)
        {
            int i; int count1 = 1;
            string strMain = "Hello World";
            string strSanjay = "Hello Sanjay";
            string input = "banana";
            string result = string.Empty;
            string replace, rev = string.Empty;
            string str11 = "Hello";
            string str12 = "Sanjay";
            string result11;
            string result12;
            string result13;
            string strValidate = "";
            string str21 = "Sanjay";
            string str22 = "sanjay";
            StringBuilder result1, sb;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] array = new int[] { 6, 7, 8, 9, 10 };
            char[] charArray;

            #region ReverseString - 1.1
            Console.WriteLine("\n1.1 ReverseString - 1");
            for (i = strSanjay.Length - 1; i >= 0; i--)
            {
                rev = rev + strSanjay[i];
            }
            Console.WriteLine("reverse string 2 : " + rev);
            #endregion 

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

            #region ReverseString - 1.3
            Console.WriteLine("\n1.3 ReverseString - 3");
            
            char[] strArray = strSanjay.ToCharArray();
            Array.Reverse(strArray);
            string NewString = new string(strArray);
            Console.WriteLine("reverse string 3 : " + NewString);
            #endregion

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

            #region IsAnagram 3
            Console.WriteLine("\n\n3. string is Anagram or not");
            string str1 = "silent";
            string str2 = "listen";
            bool isAnagram = string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
            Console.WriteLine(isAnagram ? "Anagrams" : "Not Anagrams");
            #endregion

            #region Count Occurance - 4.1
            Console.WriteLine("\n4.1 Count Occurance");
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

            #region Count Occurance with LINQ - 4.2
            Console.WriteLine("\n4.2 Count Occurance");
            
            var output = input.GroupBy(c => c)
                        .ToDictionary(g => g.Key, g => g.Count());
            Console.WriteLine(string.Join(" ", output));
            #endregion

            #region Count Occurance with Filter  - 4.3
            Console.WriteLine("\n4.3 Count Occurance with Filter");
            int count = input.Count(c => c == 'a');
            Console.WriteLine(count);
            #endregion

            #region First Non Repeating Char - 5
            Console.WriteLine("\n5 First Non Repeating Char");
            var output1 = strMain.GroupBy(c => c)
                        .Where(g => g.Count() == 1)
                        .Select(g => g.Key)
                        .FirstOrDefault();

            Console.WriteLine(string.Join(" ", output1));
            #endregion

            #region chkPalindrome - 6
            Console.WriteLine("\n6. check Palindrome");
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

            #region String Compress - 7
            Console.WriteLine("\n7. String Compress");
           
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

            #region Get Duplicate character into string 8
            Console.WriteLine("\n8. Get Duplicate character into string");
            result1 = new StringBuilder();
            HashSet<char> seenChars = new HashSet<char>();

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

            #region Replace Characters in a String 10

            Console.WriteLine("\n\n10. Replace Characters in a String");
            replace = strMain.Replace("l", "s");
            Console.WriteLine(replace); ;
            #endregion

            #region Find the Length of a String 11
            Console.WriteLine("\n\n11. Find the Length of a String");
            Console.WriteLine($"Length : {strMain.Length}");
            #endregion

            #region lower and upper case string 12
            Console.WriteLine("\n\n12. lower and upper case string");
            Console.WriteLine(strMain.ToUpper());
            Console.WriteLine(strMain.ToLower());
            #endregion

            #region split a string 13
            Console.WriteLine("\n\n13. split a string");

            string[] strword = strMain.Split(' ');
            foreach (var item in strword)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region concanate two string 14
            Console.WriteLine("\n\n14. concanate two string");
            result11 = str11 + " " + str12;
            result12 = string.Concat(str11, " ", str12);
            result13 = $"{str11} {str12}";

            Console.WriteLine(result11);
            Console.WriteLine($"Result : {result11}");
            Console.WriteLine($"Result1 : {result12}");
            Console.WriteLine($"Result2 : {result13}");
            #endregion

            #region Check Null Validation 15
            Console.WriteLine("\n\n15. Check Null Validation");
            
            if (string.IsNullOrEmpty(strValidate))
            {
                Console.WriteLine("string is null or empty");
            }
            #endregion

            #region Check String Contains 16
            Console.WriteLine("\n\n16 Check String Contains");
            if (strSanjay.Contains("Sanjay"))
            {
                Console.WriteLine("substring found !!");
            }
            #endregion

            #region Compare two strings 17
            Console.WriteLine("\n\n17 Compare two strings");
           
            bool check = str21.Equals(str22, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(check);
            #endregion

            #region Remove white space 18
            Console.WriteLine("\n\n18 Remove white space");
            string trimmed = strSanjay.Trim();
            Console.WriteLine(trimmed);
            #endregion

            #region Replace substring 19
            Console.WriteLine("\n\n19 Replace substring");
            replace = strSanjay.Replace("Sanjay", "Kanchan");
            Console.WriteLine(replace);
            #endregion

            #region Replace String To Number 20
            Console.WriteLine("\n\n20 Replace String To Number");
            string strnum = "123";
            int num = int.Parse(strnum);
            string invalid = "abc";
            bool valid = int.TryParse(invalid, out int result2);
            Console.WriteLine(num);
            Console.WriteLine(valid);
            #endregion

            #region Join array string To String 21
            Console.WriteLine("\n21 Join array string To String");
            string[] strArr = { "Hello", "Sanjay", "!" };

            string strJoin = string.Join(" ", strArr);
            Console.WriteLine(strJoin);
            #endregion

            #region Extract a substring 22
            Console.WriteLine("\n22 Extract a substring");
            string str = "Hello Sanjay How are you?";

            string substr = str.Substring(6, 6);
            Console.WriteLine(substr);
            #endregion

            #region validate Start End 23
            Console.WriteLine("\n23 validate Start End");

            bool startWith = str.StartsWith("Hello");
            bool endWith = strSanjay.EndsWith("Sanjay");
            Console.WriteLine(startWith);
            Console.WriteLine(endWith);
            #endregion

            #region escape special characters 24
            Console.WriteLine("\n24 escape special characters");
            string strEscapespecialcharacters = "He said, \"Hello!\"";
            Console.WriteLine(strEscapespecialcharacters);
            #endregion

            #region Format String 25
            Console.WriteLine("\n25 Format String");
            string name = "Sanjay";
            int age = 40;
            Console.WriteLine("Name : {0}, Age : {1}", name, age);
            Console.WriteLine($"Name : {name}, Age : {age}");
            #endregion

            #region ReverseWordOrder - 26.1
            Console.WriteLine("\n26.1. Reverse Word Order 1");

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
            #endregion

            #region  Reverse Word Order 26.2);
            Console.WriteLine("\n26.2. Reverse Words Order 15.2");
            StringBuilder output2 = new StringBuilder();
            List<char> charlist = new List<char>();

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output2.Append(charlist[j]);

                    output2.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
            #endregion

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

            #region findallsubstring - 27
            Console.WriteLine("\n27. find all substring");

            for (i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            #endregion

            #region RotateLeft 28;
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

            Console.ReadLine();
        }

    } 

}
