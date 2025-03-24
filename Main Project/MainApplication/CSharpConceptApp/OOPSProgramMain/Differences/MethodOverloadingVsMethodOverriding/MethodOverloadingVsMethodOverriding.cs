using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication.Differences.MethodOverloadingVsMethodOverriding
{
    class MethodOverloadingVsMethodOverriding
    {
        //Method Overloading
        //public static void Main(String[] args)
        //{
        //    Calculator calculator = new Calculator();
        //    calculator.Add(10, 20);
        //    calculator.Add(10, 20, 30);
        //    calculator.Add(10f, 20f);
        //    calculator.Add(10f, 20f, 30f);

        //    Console.ReadLine();
        //}

        //Method Overriding
        //static void Main(string[] args)
        //{
        //    SampleA a = new SampleA();
        //    SampleB b = new SampleB();
        //    a.Show();
        //    b.Show();
        //    a = new SampleB();
        //    a.Show();
        //    Console.ReadLine();
        //}


        //        Output

        //Sample A Test Method
        //Sample B Test Method
        // Sample B Test Method

        //Method Hiding
        //static void Main(string[] args)
        //{
        //    SampleA1 a = new SampleA1();
        //    SampleB1 b = new SampleB1();
        //    SampleB1 c = new SampleC1();
        //    a.Show();
        //    b.Show();
        //    c.Show();
        //    a = new SampleB1();
        //    a.Show();
        //    b = new SampleC1();
        //    b.Show();
        //    Console.ReadLine();
        //}

        // Output

        //Sample A Test Method
        //Sample B Test Method
        //Sample C Test Method
        //Sample A Test Method
        //Sample C Test Method
    }
    public class Calculator
    {
        //two int type Parameters method    
        public void Add(int x, int y)
        {
            int p;
            p = x + y;
            Console.WriteLine("x + y = {0}", p);
        }
        //three int type Parameters method    
        public void Add(int x, int y, int z)
        {
            int q;
            q = x + y + z;
            Console.WriteLine("x + y + z = {0}", q);
        }
        //two float type Parameters method    
        public void Add(float x, float y)
        {
            float r;
            r = x + y;
            Console.WriteLine("x + y = {0}", r);
        }

        //three float type Parameters method    
        public void Add(float x, float y, float z)
        {
            float v;
            v = x + y + z;
            Console.WriteLine("x + y + z = {0}", v);
        }
    }

    public class SampleA
    {
        public virtual void Show()
        {
            Console.WriteLine("Sample A Test Method");
        }
    }
    class SampleB : SampleA
    {
        public override void Show()
        {
            Console.WriteLine("Sample B Test Method");
        }
    }


    class SampleA1
    {
        public void Show()
        {
            Console.WriteLine("Sample A Test Method");
        }
    }
    class SampleB1 : SampleA1
    {
        public new virtual void Show()
        {
            Console.WriteLine("Sample B Test Method");
        }
    }
    class SampleC1 : SampleB1
    {
        public override void Show()
        {
            Console.WriteLine("Sample C Test Method");
        }
    }
}