using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLogicalProgram.StringManipulation
{
    #region Problem 2. Get all unique characters in a string
    //Solution. This is just the opposite of problem 1. In problem 1, we are trying to find duplicate characters, but here, we are trying to find all unique characters.This means just remove duplicate characters, and you will get a unique characters list.If you compare the above and below code, we are now returning the result objectwhere all unique characters are available.
    #endregion
    class Unique__Characters
    {
        // Find the unique characters
        public StringBuilder GetUniqueCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            HashSet<char> seenChars = new HashSet<char>();

            foreach (char item in input)
            {
                if (!seenChars.Contains(char.ToLower(item)))
                {
                    seenChars.Add(char.ToLower(item));
                    result.Append(item);
                }
            }
            return result;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter text");
        //    string str = Console.ReadLine();
        //    Unique__Characters _stringDT = new Unique__Characters();
        //    // Find the duplicate characters in the string
        //    var duplicates = _stringDT.GetUniqueCharacters(str);
        //    Console.WriteLine("Duplicate characters in {str} are: " + duplicates);
        //    Console.ReadKey();
        //}
    }
}
