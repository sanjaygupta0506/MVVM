using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Main_Concept
{
    class Reference_Type
    {
        #region ****************** Example 1 *****************************************
        static void Square(Person a, Person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }

        //static void Main(string[] args)
        //{
        //    Person p1 = new Person();
        //    Person p2 = new Person();
        //    p1.age = 5;
        //    p2.age = 10;
        //    Console.WriteLine(p1.age + " " + p2.age);
        //    Square(p1, p2);
        //    Console.WriteLine(p1.age + " " + p2.age);
        //    Console.WriteLine("Press Any Key to Exit..");
        //    Console.ReadLine();
        //}
        #endregion

        //#region ********************************* Example 2 ************************************
        public static void Multiplication(ref int a)
        {
            a *= a;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
        //    Multiplication(ref x);
        //    Console.WriteLine("Variable Value After Calling the Method: {0}", x);
        //    Console.WriteLine("Press Enter Key to Exit..");
        //    Console.ReadLine();
        //}
        //#endregion
    }

    class Person
    {
        public int age;
    }
}
