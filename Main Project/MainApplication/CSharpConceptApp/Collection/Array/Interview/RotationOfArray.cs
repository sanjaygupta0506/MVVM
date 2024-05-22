using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Array
{
    class RotationOfArray
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 11, 14, 2, 5, 1 };
        //    int position = 0, k = 0;
            
        //    Console.Write("Original Array : ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i] + " ");
        //    }

        //    Console.WriteLine();

        //    Console.Write("Enter position of rotation : ");

        //    position = Convert.ToInt32(Console.ReadLine());

        //    RotationOfArray arraySample = new RotationOfArray();
        //    while (k < position)
        //    {
        //        arraySample.LeftRotate(arr);
        //        k++;
        //    }

        //    Console.WriteLine("Rotation of array by position " + position);

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }

        //    Console.ReadLine();
        //}
        

        void LeftRotate(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }
    }
}
