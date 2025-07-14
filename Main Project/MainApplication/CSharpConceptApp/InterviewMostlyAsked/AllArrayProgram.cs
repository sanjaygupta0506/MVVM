using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Interview_Logical.ArrayManipulation
{
    public class ArrayManipulation
    {
        //public static void Main(string[] args)
        //{
        //    int[] num = new int[5];
        //    int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
        //    int[] numbers2 = { 6, 7, 8, 9, 10 };
        //    int[] numbers3 = { 6, 9, 8, 4, 10, 1, 3 };

        //    #region 1. Second Number from Array
        //    Console.WriteLine("\n*** 1. second highest number from array ***");
        //    int[] arr1 = { 3, 2, 1, 5, 4 };

        //    int largest = int.MinValue;
        //    int secondLargest = int.MinValue;

        //    foreach (int num1 in arr1)
        //    {
        //        if (num1 > largest)
        //        {
        //            secondLargest = largest;
        //            largest = num1;
        //        }
        //        else if (num1 > secondLargest && num1 != largest)
        //        {
        //            secondLargest = num1;
        //        }
        //    }

        //    Console.WriteLine("Second Largest: " + secondLargest);

        //    #endregion

        //    #region 2.1 Reverse an Array Without Using Built-in Method
        //    Console.WriteLine("\n*** 2.1 Mannual Reverse an array 1 ***");

        //    int length = numbers2.Length - 1;
        //    string strReverse = null;
        //    while (length >= 0)
        //    {
        //        strReverse += numbers2[length] + " ";
        //        length--;
        //    }

        //    Console.WriteLine(strReverse);

        //    #endregion

        //    #region 2.2 Reverse an Array Without Using Built-in Method
        //    Console.WriteLine("\n*** 2.2 Mannual Reverse an array 2 ***");

        //    int[] arr2 = { 1, 2, 3, 4, 5 };
        //    for (int i = 0; i < arr2.Length / 2; i++)
        //    {
        //        int temp = arr2[i];
        //        arr2[i] = arr2[arr2.Length - 1 - i];
        //        arr2[arr2.Length - 1 - i] = temp;
        //    }

        //    Console.WriteLine(string.Join(",", arr2));

        //    #endregion

        //    #region 3.1 remove duplicates from an array
        //    Console.WriteLine("\n*** 3.1 remove duplicates from an array - ***");
        //    int[] duplicatearray = { 1, 2, 3, 4, 2, 4, 5, 6, 1, 9 };

        //    int[] distinct = duplicatearray.Distinct().ToArray();
        //    Console.WriteLine(string.Join(",", distinct));
        //    #endregion

        //    #region 3.2 remove duplicates from an array
        //    Console.WriteLine("\n*** 3.2 remove duplicates from an array - ***");
        //    int[] arr3 = { 1, 2, 2, 3, 4, 4, 5 };
        //    List<int> result = new List<int>();

        //    foreach (int num2 in arr3)
        //    {
        //        if (!result.Contains(num2))
        //            result.Add(num2);
        //    }
        //    Console.WriteLine(string.Join(",", result));
        //    #endregion

        //    #region 4. Count Occurrences of Elements
        //    Console.WriteLine("\n*** 4. Count Occurrences of Elements ***");
        //    int[] CountOcc = { 1, 2, 2, 3, 3, 3 };
        //    Dictionary<int, int> freq = new Dictionary<int, int>();

        //    foreach (int occ in CountOcc)
        //    {
        //        if (freq.ContainsKey(occ))
        //            freq[occ]++;
        //        else
        //            freq[occ] = 1;
        //    }

        //    Console.WriteLine(string.Join(",", freq));
        //    #endregion

        //    #region 5. Rotation of Array
        //    Console.WriteLine("\n*** 5. rotation of array ***");
        //    int[] arr = new int[] { 11, 14, 2, 5, 1 };
        //    int position = 0, k = 0;

        //    //Console.Write("Original Array : ");
        //    //for (int i = 0; i < arr.Length; i++)
        //    //{
        //    //    Console.WriteLine(arr[i] + " ");
        //    //}

        //    Console.WriteLine("Original Array : " + string.Join(",", arr));

        //    Console.Write("Enter position of rotation : ");

        //    position = Convert.ToInt32(Console.ReadLine());

        //    //ArrayManipulation arraySample = new ArrayManipulation();
        //    while (k < position)
        //    {
        //        ArrayManipulation.LeftRotate(arr);
        //        k++;
        //    }

        //    Console.WriteLine("*** Rotation of array by position " + position);

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine("\n");
        //    #endregion

        //    #region 6. concatenate two arrays
        //    Console.WriteLine("\n*** 6. concatenate two arrays ***");
        //    int[] array1 = { 1, 2, 3 };
        //    int[] array2 = { 4, 5, 6 };

        //    int[] concat = array1.Concat(array2).ToArray();
        //    Console.WriteLine(string.Join(",", concat));
        //    #endregion

        //    #region  7. Check for Array Palindrome
        //    Console.WriteLine("\n*** 7. Check for Array Palindrome ***");
        //    int[] arrp = { 1, 2, 3, 2, 1 };
        //    bool isPalindrome = true;

        //    for (int i = 0; i < arrp.Length / 2; i++)
        //    {
        //        if (arrp[i] != arrp[arrp.Length - 1 - i])
        //        {
        //            isPalindrome = false;
        //            break;
        //        }
        //    }

        //    Console.WriteLine(isPalindrome);

        //    #endregion

        //    #region 8. Use LINQ to get even numbers and square them.
        //    Console.WriteLine("\n*** 8. Use LINQ to get even numbers and square them. ***");
        //    int[] arrL = { 1, 2, 3, 4, 5 };
        //    var squaredEvens = arrL.Where(x => x % 2 == 0).Select(x => x * x).ToArray();
        //    Console.WriteLine(string.Join(",", squaredEvens));
        //    #endregion

        //    #region 9. Declare and initiaze value in array

        //    Console.WriteLine("\n*** 9. Declare and initiaze value in array ***");
        //    Console.WriteLine("\n*** - Array 1 - ***");
        //    Console.WriteLine(string.Join(",", numbers1));
        //    Console.WriteLine("\n*** - Array 2 - ***");
        //    Console.WriteLine(string.Join(",", numbers2));
        //    #endregion

        //    #region 10. To Find Length of Array
        //    Console.WriteLine("\n*** 10. Length of Array ***");
        //    Console.WriteLine("Length of Array - " + numbers1.Length);
        //    #endregion

        //    #region  11. loop through an array
        //    Console.WriteLine("\n*** 11. loop through an array ***");

        //    Console.WriteLine("\n*** - Array 1 - ***");
        //    foreach (var item1 in numbers1)
        //    {
        //        Console.WriteLine(item1);
        //    }

        //    Console.WriteLine("\n*** - Array 2 - ***");
        //    for (int i = 0; i < numbers2.Length; i++)
        //    {
        //        Console.WriteLine(numbers2[i]);
        //    }

        //    #endregion

        //    #region 12. Reverse an Array With Using Built-in Method
        //    Console.WriteLine("\n*** 12. Reverse an array ***");
        //    Array.Reverse(numbers1);
        //    Console.WriteLine(string.Join(",", numbers1));
        //    #endregion

        //    #region 13. Sort an array
        //    Console.WriteLine("\n*** 13. Sort an array ***");
        //    Array.Sort(numbers3);
        //    Console.WriteLine(string.Join(",", numbers3));
        //    #endregion

        //    #region 14. largest and smallest elements in an array 
        //    Console.WriteLine("\n*** 14.1 largest and smallest elements in an array with LINQ ***");
        //    int Max = numbers3.Max();
        //    int Min = numbers3.Min();

        //    Console.WriteLine("Max - " + Max);
        //    Console.WriteLine("Max - " + Min);

        //    Console.WriteLine("\n*** 14.2 largest and smallest elements in an array without LINQ ***");
        //    int Maxelement = numbers3[0];
        //    int Minelement = numbers3[0];

        //    foreach (var number in numbers3)
        //    {
        //        if (number > Maxelement)
        //        {
        //            Maxelement = number;
        //        }
        //        if (number < Minelement)
        //        {
        //            Minelement = number;
        //        }
        //    }

        //    Console.WriteLine("Max - " + Maxelement);
        //    Console.WriteLine("Max - " + Minelement);


        //    #endregion

        //    #region 15. copy an array
        //    Console.WriteLine("\n*** 15. copy an array ***");
        //    int[] copy = new int[numbers3.Length];
        //    Array.Copy(numbers3, copy, numbers3.Length);
        //    Console.WriteLine(string.Join(",", numbers3));
        //    #endregion

        //    #region 16. find if an element exists in an array
        //    Console.WriteLine("\n*** 16. find if an element exists in an array ***");
        //    bool exists = Array.Exists(numbers3, element => element == 3);
        //    Console.WriteLine(exists);
        //    #endregion

        //    #region 17. find the sum and average of an array
        //    Console.WriteLine("\n*** 17. find the sum and average of an array - ***");

        //    int sum = numbers3.Sum();
        //    double Average = numbers3.Average();

        //    Console.WriteLine("Sum - " + sum);
        //    Console.WriteLine("Avg - " + Average);

        //    #endregion

        //    #region 18. find the index of an element in an array
        //    Console.WriteLine("\n*** 18. find the index of an element in an array - ***");

        //    int index = Array.IndexOf(numbers3, 3);
        //    Console.WriteLine("Index - " + index);
        //    #endregion

        //    #region 19. resize an array
        //    Console.WriteLine("\n*** 19. resize an array - ***");
        //    Array.Resize(ref array1, 6);
        //    array1[3] = 4;
        //    array1[4] = 5;
        //    array1[5] = 6;

        //    Console.WriteLine(string.Join(",", array1));
        //    #endregion

        //    #region 20. create a multi-dimensional array
        //    Console.WriteLine("\n*** 20. create a multi-dimensional array ***");

        //    int[,] matrix = new int[2, 3]
        //    {
        //        { 1, 2, 3},
        //        { 4, 5, 6}
        //    };
        //    Console.WriteLine(matrix[1, 2]);
        //    #endregion

        //    #region 21. create a jagged array
        //    Console.WriteLine("\n*** 21. create a jagged array ***");
        //    int[][] jaggedArray = new int[2][];
        //    jaggedArray[0] = new int[] { 1, 2, 3 };
        //    jaggedArray[1] = new int[] { 4, 5, 6 };
        //    foreach (int[] subArray in jaggedArray)
        //    {
        //        foreach (int number in subArray)
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }
        //    #endregion

        //    #region 22. calculate sum of all even numbers 
        //    Console.WriteLine("\n*** 22. calculate sum of all even numbers ***");
        //    int sumOfEvens = SumOfEvenNumbers(numbers3);
        //    Console.WriteLine($"Sum of even numbers: {sumOfEvens}");

        //    #endregion
        //    Console.ReadLine();
        //}

        public static void LeftRotate(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }

        public static int SumOfEvenNumbers(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum();
        }
    }
}
