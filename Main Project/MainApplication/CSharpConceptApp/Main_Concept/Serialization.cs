using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CSharpConceptApp.Main_Concept
{
    class Serialization
    {
        //public static void Main(string[] args)
        //{
        //    UserDetails ud = new UserDetails(1, "Sanjay", "Faridabad");
        //    Console.WriteLine("Before serialization the object contains : ");
        //    ud.GetDetails();
        //    string fpath = @"E:\Test.txt";
        //    if (File.Exists(fpath))
        //    {
        //        File.Delete(fpath);
        //    }

        //    //Opens a file and serializes the object into it in binary format.
        //    Stream stream = File.Open(fpath, FileMode.Create);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(stream, ud);
        //    stream.Close();
        //    Console.WriteLine("\nSerialazation Successful");
        //    Console.ReadLine();

        //}
    }

    [Serializable()]
    public class UserDetails
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string location { get; set; }
        public UserDetails(int id, string name, string place)
        {
            userId = id;
            userName = name;
            location = place;
        }
        public void GetDetails()
        {
            Console.WriteLine("UserId: {0}", userId);
            Console.WriteLine("UserName: {0}", userName);
            Console.WriteLine("Location: {0}", location);
        }
    }
}
