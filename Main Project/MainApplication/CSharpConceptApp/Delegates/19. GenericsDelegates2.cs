using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Delegates
{
    class GenericsDelegates2
    {
        // A method that takes an integer and returns a string
        public static double Addition_Func(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void Addition_Action(int no1, float no2, double no3)
        {
            Console.WriteLine("Result of Addition with Action Generic Delegate: " + (no1 + no2 + no3));
        }
        public static bool Validate_string(string name)
        {
            if (name.Length < 15) return true;
            return false;
        }

        //static void Main(string[] args)
        //{
        //    Func<int, float, double, double> Func_Object = new Func<int, float, double, double>(Addition_Func);
        //    double Result = Func_Object.Invoke(100, 125.45f, 456.789);
        //    Console.WriteLine("Result of Addition with Func Generic Delegate: " + Result);
        //    Action<int, float, double> Action_Object = new Action<int, float, double>(Addition_Action);
        //    Action_Object.Invoke(50, 255.45f, 123.456);
        //    Predicate<string> Predicate_Object = new Predicate<string>(Validate_string);
        //    bool Status = Predicate_Object.Invoke("Sanjay Gupta");
        //    Console.WriteLine("Result with Predicate Generic Delegate: " + Status);
        //    Console.ReadLine();
        //}
    }
}



