using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.Solid_Principles._1._SRP
{
    public class SRPOrderService
    {
        public static void OrderService(int orderid)
        {
            Console.WriteLine("Processed Order :-  " + orderid);
        }
        
    }

    public class SRPSendEmail
    {
        public static void SendEmail(string Email)
        {
            Console.WriteLine("Email Sending to :-  " + Email);
        }
    }

    class MainCls
    {
        //public static void Main(string[] args)
        //{
        //    SRPOrderService.OrderService(5);
        //    SRPSendEmail.SendEmail("sanjaygupta0506@gmail.com");
        //    Console.ReadLine();
        //}
    }
}
