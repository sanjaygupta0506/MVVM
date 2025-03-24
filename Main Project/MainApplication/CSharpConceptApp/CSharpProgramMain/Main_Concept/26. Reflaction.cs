using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace CSharpConceptApp.Main_Concept
{
    class Reflaction
    {
        ////Example -1 
        //static void Main(string[] args)
        //{
        //    List<userdetails> items = new List<userdetails>();
        //    items.Add(new userdetails { userid = 1, username = "suresh", location = "chennai" });
        //    items.Add(new userdetails { userid = 2, username = "rohini", location = "guntur" });
        //    items.Add(new userdetails { userid = 3, username = "praveen", location = "bangalore" });
        //    items.Add(new userdetails { userid = 4, username = "sateesh", location = "vizag" });
        //    items.Add(new userdetails { userid = 5, username = "madhav", location = "nagpur" });
        //    items.Add(new userdetails { userid = 6, username = "honey", location = "nagpur" });

        //    string strmsg = string.Empty;
        //    foreach (var user in items)
        //    {
        //        strmsg = GetPropertyValues(user);
        //        //strmsg = (user.userid, user.username, user.location).ToString();
        //        Console.WriteLine(strmsg);
        //    }
        //    Console.ReadLine();
        //}
        private static string GetPropertyValues(userdetails user)
        {

            Type type = user.GetType();
            PropertyInfo[] props = type.GetProperties();
            string str = "{";
            foreach (var prop in props)
            {
                str += (prop.Name + ":" + prop.GetValue(user) + ":" + prop.PropertyType.Name) + ",";
            }
            return str.Remove(str.Length - 1) + "}";
        }
        ////Example -2
        //static void Main(string[] args)
        //{
        //    MyClass oMyClass = new MyClass();
        //    //Type information.
        //    Type oMyType = oMyClass.GetType();
        //    //Method information.
        //    MethodInfo oMyMethodInfo = oMyType.GetMethod("Subtract");
        //    Console.WriteLine("nType information:" + oMyType.FullName);
        //    Console.WriteLine("nMethod info:" + oMyMethodInfo.Name);
        //    Console.Read();
        //}
    }
    class userdetails
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string location { get; set; }
    }
    public class MyClass
    {
        public virtual int Add(int numb1, int numb2)
        {
            return numb1 + numb2;
        }
        public virtual int Subtract(int numb1, int numb2)
        {
            return numb1 - numb2;
        }
    }
}
