using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Design_Pattern
{
    class SingletonClass
    {
        public static void Main(string[] args)
        {
            Singleton.Instance.Print();
            Singleton.Instance.Add(5, 8);
            Singleton.Instance.Value1 = 10;
            Singleton.Instance.Value2 = 5;
            Singleton.Instance.Subtract();
            Console.ReadLine();
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
               if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
                
        }

        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public void Print()
        {
            Console.WriteLine("SingleTon Example");
        }

        public double Add( double a, double b)
        {
            double  c = a + b;
            Console.WriteLine("Add :" + c);
            return 0;
        }

        public double Subtract()
        {
            double Value3 = Value1 - Value2;
            Console.WriteLine("Subtraction :" + Value3);
            return 0;
        }

    }
}
