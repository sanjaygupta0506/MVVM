using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM.Design_Pattern.Singletons
{
    /// <summary>
    /// Interaction logic for Singleton_Types.xaml
    /// </summary>
    public partial class Singleton_Types : WslDialog
    {
        public Singleton_Types()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Calculator.Instance.ValueOne = 100;
            Calculator.Instance.ValueTwo = 10;
            txtAdd.Text = ("Addition : " + Calculator.Instance.Addition());
            txtSub.Text = ("Subtraction : " + Calculator.Instance.Subtraction());
            txtMul.Text = ("Multiplication : " + Calculator.Instance.Multiplicaion());
            txtDiv.Text = ("Division : " + Calculator.Instance.Division());
            txt5.Text = ("From Teacher : " + Calculator.Instance.PrintDetails("From Teacher"));
            txt6.Text = ("From Student :" + Calculator.Instance.PrintDetails("From Student"));
        }
    }

    #region Main
    public sealed class Calculator
    {
        private static Calculator instance = null;
        private static int counter = 0;
        private Calculator()
        {
            counter++;
            MessageBox.Show("Counter Value : " + counter.ToString());
        }


        public static Calculator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculator();
                }
                return instance;
            }
        }

        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }

        public double Multiplicaion()
        {
            return ValueOne * ValueTwo;
        }

        public double Division()
        {
            return ValueOne / ValueTwo;
        }

        public string PrintDetails(string message)
        {
            return message;
        }
    }
    #endregion

    #region No Thread Safe Singleton
    // Bad code! Do not use!  
    public sealed class Singleton1
    {
        private Singleton1()
        {

        }
        private static Singleton1 instance1 = null;
        public static Singleton1 Instance1
            {
                get
                {
                    if (instance1 == null)
                    {
                        instance1 = new Singleton1();
                    }
                    return instance1;
                }
            }
    }

    #endregion

    #region Thread Safety Singleton
    public sealed class Singleton2
    {
        private Singleton2()
        {

        }
        private static Singleton2 instance2 = null;
        private static readonly object padlock = new object();
        public static Singleton2 Instance2
            { 
                get
                {
                lock (padlock) 
                    {
                        if (instance2 == null)
                        {
                            instance2 = new Singleton2();
                        }
                        return instance2;
                    }
                }
               
            }
    }
    #endregion

    #region Thread Safety Singleton using Double Check Locking
    public sealed class Singleton3
    {
        Singleton3()
        {
        }
        private static readonly object padlock = new object();
        private static Singleton3 instance = null;
        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }
    #endregion

    #region Thread Safe Singleton without using locks and no lazy instantiation
    public sealed class Singleton4
    {
        private static readonly Singleton4 instance = new Singleton4();
        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static Singleton4()
        {
        }
        private Singleton4()
        {
        }
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
    #endregion

    #region Fully lazy instantiation
    public sealed class Singleton5
    {
        private static readonly Singleton5 instance = new Singleton5();
        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static Singleton5()
        {
        }
        private Singleton5()
        {
        }
        public static Singleton5 Instance
        {
            get
            {
                return instance;
            }
        }
    }
    #endregion

    #region Using .NET 4's Lazy<T> type
    public sealed class Singleton6
    {
        private Singleton6()
        {
        }
        private static readonly Lazy<Singleton6> lazy = new Lazy<Singleton6>(() => new Singleton6());
        public static Singleton6 Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
    #endregion

}
