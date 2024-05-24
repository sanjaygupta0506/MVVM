using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Main_Concept
{
    class Value_Type
    {
        #region ****************** Example 1 *****************************************
        static void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        #endregion

        //#region ****************** Example 2 *****************************************
        //static void Multiplication(int a)
        //{
        //    a *= a;
        //    Console.WriteLine("Variable Value Inside the Method: {0}", a);
        //}
        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
        //    Multiplication(x);
        //    Console.WriteLine("Variable Value After Calling the Method: {0}", x);
        //    Console.WriteLine("Press Enter Key to Exit..");
        //    Console.ReadLine();
        //}
        //#endregion
    }
}
