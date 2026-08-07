using CSharpConceptApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConsoleAppMain.CSharpProgramMain.Main_Concept.Collection
{
    public static class Collection_Main
    {
        public static void Array_Concept()
        {
            int[] number = new int[5];
            int[] number1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] number2 = { 10, 20, 30 };
            int[,] number3 = { { 1, 2 }, { 3, 4 } };
            
            Console.WriteLine("Array Type1 : Without loop ");
            Console.WriteLine(number1[2]);

            Console.WriteLine("Array Type2: Foreach without value");
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array Type3 : Foreach with value ");
            foreach (var item1 in number1)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine("Array Type4 : For loop with value");
            for (int i = 0; i < number2.Length; i++)
            {
                Console.WriteLine(number2[i]);
            }
            number1[2] = 100;
            Console.WriteLine("Array Type5 : Modify Array");
            foreach (var item2 in number2)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("Array Type6 : Array Length");
            Console.WriteLine(number1.Length);

            Console.WriteLine("Array Type7 : Array Rank");
            Console.WriteLine(number1.Rank);

            Console.WriteLine("Array Type8 : Two Dimensional Array");
            foreach (var item3 in number3)
            {
                Console.WriteLine(item3);
            }


            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Collection_Main.Array_Concept();
        }
    }
}
