using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Interview
{
    #region Task 1 - Will Not execute - due to samme name and same parameter
    //public static class Task1
    //{
    //    public static int DoWork(int a, int b)
    //    {
    //        return 1;
    //    }

    //    private static string DoWork(int a, int b)
    //    {
    //        return "Hello";
    //    }
    //}

    //class TaskImplement
    //{
    //    public static void Main(string[] ags)
    //    {
    //        Task1.DoWork(4, 5);
    //        Console.ReadLine();
    //    }

    //}
    #endregion

    #region Task 2 - O/P Derived Called
    //internal class Task1
    //{
    //    static void Main(string[] args)
    //    {
    //        Base baseObj = new Derived();
    //        baseObj.DoWork();
    //        Console.ReadLine();
    //    }
    //}

    //class Base
    //{
    //    public virtual void DoWork()
    //    {
    //        Console.WriteLine("Based Called");
    //    }
    //}

    //class Derived : Base
    //{
    //    public override void DoWork()
    //    {
    //        Console.WriteLine("Derived Called");
    //    }
    //}
    #endregion

    #region Task 3 - O/P TestValue : 10

    //public class TestStatic
    //{
    //    public static int TestValue;

    //    public TestStatic()
    //    {
    //        if (TestValue == 0)
    //        {
    //            TestValue = 5;
    //        }
    //    }
    //    static TestStatic()
    //    {
    //        if (TestValue == 0)
    //        {
    //            TestValue = 10;
    //        }
    //    }

    //    public void Print()
    //    {
    //        if (TestValue == 5)
    //        {
    //            TestValue = 6;
    //        }
    //        Console.WriteLine("TestValue : " + TestValue);

    //    }
    //}

    //public class  Task1
    //{
    //    public static void Main(string[] args)
    //    {
    //        TestStatic t = new TestStatic();
    //        t.Print();
    //        Console.ReadLine();
    //    }
    //}
    
    #endregion
}
