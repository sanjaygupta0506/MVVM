using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLogicalProgram.StringManipulation
{
    #region Problem 1. Find duplicate characters in a string
    //Solution.In this sample code, we have a string, and we need to find all duplicate characters in the string. 
    #endregion
    class Duplicate_characters
    {
        // Find the duplicate characters
        public StringBuilder GetDuplicateCharacters(string input)
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

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter text");
        //    string str = Console.ReadLine();
        //    Duplicate_characters _stringDT = new Duplicate_characters();
        //    Find the duplicate characters in the string
        //   var duplicates = _stringDT.GetDuplicateCharacters(str);
        //    Console.WriteLine("Duplicate characters in {str} are: " + duplicates);
        //    Console.ReadKey();
        //}
    }

}
