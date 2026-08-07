using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.Solid_Principles
{
    public class SPMain
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("*** Single Responsibility Principle (SRP) Example ***");
        //    new EmployeeRepository().Save();
        //    new EmailService().SendEmail();
        //    new ReportService().GenerateReport();

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Open/Closed Principle (OCP) Example  ***");
        //    Shape S1 = new Circle() { radius = 7 };
        //    Shape S2 = new Rectangle() { length = 5, width = 10 };
        //    Console.WriteLine($"Area of Circle: {S1.Area()}");
        //    Console.WriteLine($"Area of Rectangle: {S2.Area()}");

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Liskov Substitution Principle (LSP) Example  ***");
        //    Bird bird1 = new Sparrow();
        //    Bird bird2 = new Penguin();
        //    bird1.Move();
        //    bird2.Move();

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Interface Segregation Principle (ISP) Example  ***");
        //    IPrint printer = new Printer();
        //    printer.Print();
        //    IScan scanner = new Scanner();
        //    scanner.Scan();
        //    MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        //    multiFunctionPrinter.Print();
        //    multiFunctionPrinter.Scan();

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Dependency Inversion Principle (DIP) Example  ***");
        //    NotificationService emailService = new NotificationService(new EMailSender());
        //    emailService.notify("Welcome, this is a test email notification");
        //    NotificationService smsService = new NotificationService(new SmsSender());
        //    smsService.notify("Welcome, this is a test SMS notification");



        //    Console.ReadLine();
        //}
    }

    #region Single Responsibility Principle (SRP) Example

    class EmployeeRepository
    {
        public void Save()
        {
            Console.WriteLine("Employee data saved to database.");
        }
    }

    class EmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Email sent to employee.");
        }
    }

    class ReportService
    {
        public void GenerateReport()
        {
            Console.WriteLine("Report generated for employee.");
        }
    }
    #endregion

    #region Open/Closed Principle (OCP) Example 

    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        public double radius { get; set; }
        public override double Area()
        {
            return Math.Round(Math.PI * radius * radius);
        }
    }

    class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public override double Area()
        {
            return length * width;
        }
    }
    #endregion

    #region Liskov Substitution Principle (LSP) Example

    class Bird
    {
        public virtual void Move()
        {
            Console.WriteLine("Bird is Moving.");
        }
    }

    class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

    class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin is walking.");
        }
    }
    #endregion

    #region Interface Segregation Principle (ISP) Example
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }

    class Printer : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Only Printing 1st document...");
        }
    }

    class Scanner : IScan
    {
        public void Scan()
        {
            Console.WriteLine("Only Scanning 1st document...");
        }
    }

    class MultiFunctionPrinter : IPrint, IScan
    {
        public void Print()
        {
            Console.WriteLine("Printing 2nd document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning 2nd document...");
        }
    }

    #endregion

    #region Dependency Inversion Principle Example
    interface IMessageSender
    {
        void SendMessage(string message);
    }
    class EMailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS Sent: {message}");
        }
    }

    class NotificationService
    {
        private readonly IMessageSender messageSender;
        public NotificationService(IMessageSender _messageSender)
        {
            messageSender = _messageSender;
        }

        public void notify(string message)
        {
            messageSender.SendMessage(message);
        }
    }

    #endregion

    
}
