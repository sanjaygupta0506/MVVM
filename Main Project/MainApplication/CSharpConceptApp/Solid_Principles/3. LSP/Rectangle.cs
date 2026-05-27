using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain.Solid_Principles._3._LSP
{
    public class Rectangle
    {
        public virtual int width { get; set; }
        public virtual int height { get; set; }
        public int Area() => width * height;
    }

    public class Square : Rectangle
    {
        public override int width { get => base.width; set => base.width = value; }
        public override int height { get => base.height; set => base.height = value; }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Without LSP");
           
        //    Console.ReadLine();
        //}
    }

}
