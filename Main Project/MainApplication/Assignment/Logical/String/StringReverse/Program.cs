using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string str = Console.ReadLine();
            string rev = string.Empty;
            //reverse the string, start from back and store in a new variable
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            Console.WriteLine("reverse string " + rev);
            Console.ReadLine();
        }
    }
}
