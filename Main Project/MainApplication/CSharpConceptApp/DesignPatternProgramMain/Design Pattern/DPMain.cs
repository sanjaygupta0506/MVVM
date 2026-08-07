using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.Design_Pattern
{
    class DPMain
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine("*** Singleton Pattern Example  ***");
        //    SingletonDemo singleton1 = SingletonDemo.Instance;
        //    SingletonDemo singleton2 = SingletonDemo.Instance;
        //    singleton1.display();
        //    Console.WriteLine($"Are both instances same? {singleton1 == singleton2}");


        //    Console.WriteLine("");
        //    Console.WriteLine("*** Thread Safe Singleton Pattern Example  ***");
        //    ThreadSafeSingleton threadSafeSingleton1 = ThreadSafeSingleton.Instance;
        //    ThreadSafeSingleton threadSafeSingleton2 = ThreadSafeSingleton.Instance;
        //    threadSafeSingleton1.display();
        //    Console.WriteLine($"Are both instances same? {threadSafeSingleton1 == threadSafeSingleton2}");

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Dependency Injection - Constructor  ***");
        //    ILoggerConstructor fileLogger = new FileLogger();
        //    ILoggerConstructor databaseLogger = new DatabaseLogger();
        //    EmployeeService employeeService1 = new EmployeeService(fileLogger);
        //    EmployeeService employeeService2 = new EmployeeService(databaseLogger);
        //    employeeService1.AddEmployee("Sanjay");
        //    employeeService2.AddEmployee("Kanchan");

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Dependency Injection - Property  ***");
        //    ILoggerProperty filelogger = new Filelogger();
        //    ILoggerProperty databaselogger = new Databaselogger();
        //    EmployeeServiceProperty employeeServiceProperty = new EmployeeServiceProperty();
        //    employeeServiceProperty.loggerProperty =  filelogger;
        //    employeeServiceProperty.SaveEmployee();

        //    Console.WriteLine("");
        //    Console.WriteLine("*** Dependency Injection - Method  ***");
        //    ILoggerMethod loggerMethod1 = new FileLoggerMethod();
        //    ILoggerMethod loggerMethod2 = new DatabaseLoggerMethod();
        //    EmployeeServiceMethod employeeServiceMethod = new EmployeeServiceMethod();
           
        //    employeeServiceMethod.SaveEmployee(new FileLoggerMethod());

        //    //Singleton.Instance.Print();
        //    //Singleton.Instance.Add(5, 8);
        //    //Singleton.Instance.Value1 = 10;
        //    //Singleton.Instance.Value2 = 5;
        //    //Singleton.Instance.Subtract();
        //    Console.ReadLine();
        //}
    }

    #region Singleton Design Pattern Example
    public sealed class SingletonDemo
    {
        private static SingletonDemo instance = null;

        private SingletonDemo()
        {
            Console.WriteLine("Singleton class instance created.");
        }

        public static SingletonDemo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonDemo();
                }
                return instance;
            }
        }

        public void display()
        {
            Console.WriteLine("This is default message from Singleton class.");
        }
    }
    #endregion

    #region Thread Safe Singleton Design Pattern with lock

    sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static readonly object _lock = new object();
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Thread Safe Singleton class instance created.");
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }

        public void display()
        {
            Console.WriteLine("This is default message from Thread Safe Singleton class.");
        }
    }
    #endregion

    #region Dependency Injection - Constructor
    interface ILoggerConstructor
    {
        void Log(string message);
    }
    public class FileLogger : ILoggerConstructor        
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger : {message}");
        }
    }

    public class DatabaseLogger : ILoggerConstructor
    {
        public void Log(string message)
        {
            Console.WriteLine($"Database Logger : {message}");
        }
    }

    class EmployeeService
    {
        private readonly ILoggerConstructor logger;
        public EmployeeService(ILoggerConstructor logger)
        {
            this.logger = logger;
        }

        public void AddEmployee(string name)
        {
            // Logic to add employee
            Console.WriteLine($"Employee {name} added.");
            logger.Log($"Employee {name} added.");
        }

    }


    #endregion

    #region Dependency Injection - Property
    interface ILoggerProperty
    {
        void Log(string message);
    }

    public class Filelogger :ILoggerProperty
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger : {message}");
        }
    }

    public class Databaselogger : ILoggerProperty
    {
        public void Log(string message)
        {
            Console.WriteLine($"Database Logger : {message}");
        }
    }
    

    class EmployeeServiceProperty
    {
        public ILoggerProperty loggerProperty { get; set; }
        public void SaveEmployee()
        {
            Console.WriteLine("Employee Saved");

            loggerProperty.Log("EmployeeServiceProperty initialized.");
        }
    }
    #endregion

    #region #region Dependency Injection - Method
    interface ILoggerMethod { 
        void Log(string message);
    }

    public class FileLoggerMethod : ILoggerMethod
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger : {message}");
        }
    }

    public class DatabaseLoggerMethod : ILoggerMethod
    {
        public void Log(string message)
        {
            Console.WriteLine($"Database Logger : {message}");
        }
    }

    class EmployeeServiceMethod
     {
        public void SaveEmployee(ILoggerMethod logger)
        {
            Console.WriteLine("Employee Saved");
            logger.Log("EmployeeServiceMethod initialized.");
        }
     }

    #endregion

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
