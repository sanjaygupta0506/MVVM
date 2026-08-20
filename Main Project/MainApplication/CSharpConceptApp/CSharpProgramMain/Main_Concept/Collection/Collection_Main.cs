using CSharpConceptApp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConsoleAppMain.CSharpProgramMain.Main_Concept.Collection
{
    public static class Collection_Main
    {
        public static void Array_Concept()
        {
            int[] number1 = new int[5];
            int[] number2 = new int[5] { 10, 20, 30, 40, 50 };
            string[] number3 = { "Sanjay", "Kanchan", "Devansh", "Divyanshi" };
            int[,] number4 = { { 1, 2 }, { 3, 4 } };
            int[][] number5 = new int[3][];

            Console.WriteLine("Array Type1 : Without loop ");
            Console.WriteLine(number2[2]);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type2: Foreach without value");
            number1[0]= 10; number1[2] = 30;
            foreach (var item in number1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type3 : ImplicitlyTypedArray");
            foreach (var item1 in number3)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type4 : For loop with value");
            for (int i = 0; i < number2.Length; i++)
            {
                Console.WriteLine(number2[i]);
            }
            number1[2] = 100;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type5 : Modify Array");
            foreach (var item2 in number2)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type6 : Array Length");
            Console.WriteLine(number2.Length);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type7 : Array Rank");
            Console.WriteLine(number2.Rank);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type8 : Array Sort");
            Array.Sort(number2);
            foreach (var item in number2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type9 : Array Reverse");
            Array.Reverse(number2);
            foreach (var item in number3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type10 : Two Dimensional Array");
            foreach (var item4 in number4)
            {
                Console.WriteLine(item4);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Array Type10 : Jagged Array");
            number5[0] = new int[] { 1,2,3 };
            number5[1] = new int[] { 4,5,6 };
            number5[2] = new int[] { 7,8,9 };

            for (int i = 0; i < number5.Length; i++)
            {
                for (int j = 0; j < number5[i].Length; j++)
                {
                    Console.Write(number5[i][j] + " ");
                }
                Console.WriteLine();
            }

           

            Console.ReadLine();
        }
        public static void ArrayList_Concept()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(10);
            arrayList1.Add("Sanjay");
            arrayList1.Add(30);
            arrayList1.Add(true);
            arrayList1.Add(50.5);
            ArrayList arrayList2 = new ArrayList() { 10, 20, 30, 40, 50 };
            Console.WriteLine("ArrayList Type1 : Reading Items ");
            Console.WriteLine(arrayList1[0]);
            Console.WriteLine(arrayList1[1]);

            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Type2: Foreach");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            arrayList2.Insert(2, "Sanjay");
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Methods : Insert");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.WriteLine(arrayList2[i]);
            }

            arrayList2.Remove("Sanjay");
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Methods : Remove");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.WriteLine(arrayList2[i]);
            }

            arrayList2.RemoveAt(1);
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Methods : RemoveAt");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.WriteLine(arrayList2[i]);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Methods : Contains");
            Console.WriteLine(arrayList2.Contains(10));
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Methods : IndexOf");
            Console.WriteLine(arrayList1.IndexOf(10));
            
            Console.WriteLine("ArrayList Methods : Count");
            Console.WriteLine(arrayList1.Count);
            Console.WriteLine("ArrayList Methods : Clear");
            

            arrayList1[2] = 100;
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayList Type4 : Modify ArrayList");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            arrayList1.Clear();
            Console.ReadLine();
        }
        public static void List_Concept()
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            list1.Add(50);
            List<string> list2 = new List<string>();
            list2.Add("Sanjay");
            list2.Add("Ravi");
            list2.Add("Anita");
            list2.Add("John");
            list2.Add("Doe");
            List<int> list3 = new List<int>()
            { 1,2,3,4};
            Console.WriteLine("List Type1 : Without loop ");
            Console.WriteLine(list1[2]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("List Type2: Foreach without value");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            
            list1[2] = 100;
            Console.WriteLine("------------------------------");
            Console.WriteLine("List Type4 : Modify List");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List Type5 : Count");
            Console.WriteLine(list1.Count);

            Console.WriteLine("List Type6 : Capacity");
            Console.WriteLine(list1.Capacity);

            Console.ReadLine();
        }
        public static void Hashtable_Concept()
        {
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add(1, "Sanjay");
            hashtable1.Add(2, "2");
            hashtable1.Add(3, "Anita");
            hashtable1.Add(4, "4");
            hashtable1.Add(5, "Doe");
            Console.WriteLine("Hashtable Type1 : Without loop ");
            Console.WriteLine(hashtable1[2]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Hashtable Type2: Foreach without value");
            foreach (var item in hashtable1)
            {
                Console.WriteLine(item);
            }
            hashtable1[2] = "Ramesh";
            Console.WriteLine("------------------------------");
            Console.WriteLine("Hashtable Type4 : Modify Hashtable");
            foreach (var item in hashtable1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hashtable Type5 : Count");
            Console.WriteLine(hashtable1.Count);
            Console.ReadLine();
        }
        public static void Dictionary_Concept()
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "Sanjay");
            dict1.Add(2, "Ravi");
            dict1.Add(3, "Anita");
            dict1.Add(4, "John");
            dict1.Add(5, "Doe");
            Console.WriteLine("Dictionary Type1 : Without loop ");
            Console.WriteLine(dict1[2]);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Dictionary Type2: Foreach without value");
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            dict1[2] = "Ramesh";
            Console.WriteLine("------------------------------");
            Console.WriteLine("Dictionary Type4 : Modify Dictionary");
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("Dictionary Type5 : Count");
            Console.WriteLine(dict1.Count);
            Console.ReadLine();
        }
        //public static void Main(string[] args)
        //{
        //    //Collection_Main.Array_Concept();
        //    Collection_Main.ArrayList_Concept();
        //    //Collection_Main.List_Concept();
        //    //Collection_Main.Hashtable_Concept();
        //    //Collection_Main.Dictionary_Concept();
        //}
    }
}
