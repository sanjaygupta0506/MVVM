using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.Solid_Principles._1._SRP
{
    class OrderService
    {
        public static void ProcessOrder(int orderid)
        {
            Console.WriteLine("Processed Order :-  " + orderid);
        }

        public static void SendingEmail(string Email)
        {
            Console.WriteLine("Email Sending to :-  " + Email);
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Without SRP");
        //    ProcessOrder(5);
        //    SendingEmail("sanjaygupta0506@gmail.com");
        //    Console.ReadLine();
        //}

    }

    
}
