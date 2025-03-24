using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptApplication
{
    class Interface
    {
        ////Calling Type 1 
        //static void Main(string[] args)
        //{
        //    IUser u = new Interface_User();
        //    u.GetDetails("Suresh Dasari");
        //    IUser u1 = new Interface_User1();
        //    u1.GetDetails("Hyderabad");
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}

        ////C# Multiple Inheritance with Interface - Calling Type 2
        //static void Main(string[] args)
        //{
        //    MI_User u = new MI_User();
        //    u.GetName("Suresh Dasari");
        //    u.GetLocation("Hyderabad");
        //    u.GetAge(32);
        //    Console.WriteLine("\nPress Enter Key to Exit..");
        //    Console.ReadLine();
        //}

        //// Multiple Interface with same method - Calling Type 2
        //static void Main(string[] args)
        //{
        //    IBankCustomer bc = new Customer();
        //    bc.GetCustomerInfo();

        //    ILoanCustomer lc = new Customer();
        //    lc.GetCustomerInfo();
        //    Console.ReadLine();
        //}
    }
}

     #region Type 1

interface IUser
{
    void GetDetails(string x);
}

class Interface_User : IUser
{
    public void GetDetails(string a)
    {
        Console.WriteLine("Name: {0}", a);
    }
}

class Interface_User1 : IUser
{
    public void GetDetails(string a)
    {
        Console.WriteLine("Location: {0}", a);
    }
}
#endregion

     #region Type 2

interface IName
{
    void GetName(string x);
}

interface ILocation
{
    void GetLocation(string x);
}

interface IAge
{
    void GetAge(int x);
}

class MI_User : IName, ILocation, IAge
{
    public void GetName(string a)
    {
        Console.WriteLine("Name: {0}", a);
    }

    public void GetLocation(string a)
    {
        Console.WriteLine("Location: {0}", a);
    }

    public void GetAge(int a)
    {
        Console.WriteLine("Age: {0}", a);
    }
}
#endregion

     #region Type 3 

interface ILoanCustomer
{
    void GetCustomerInfo();
}
interface IBankCustomer
{
    void GetCustomerInfo();
}
class Customer : ILoanCustomer, IBankCustomer
{
    //Explicit implementation of ILoanCustomer interface
    void ILoanCustomer.GetCustomerInfo()
    {
        Console.WriteLine("Loan Customer ...");

    }
    //Explicit IBankCustomer of ILoanCustomer interface
    void IBankCustomer.GetCustomerInfo()
    {
        Console.WriteLine("Bank Customer ...");

    }
}

#endregion


