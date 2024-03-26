using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>() { "Independence" };
            int counter = 0;
            Console.WriteLine("Input string: " + str);
            char currentChar = new char();

            //sort char alphabetically
            var item = str.FirstOrDefault().ToLower().OrderBy(x => x).ToList();

            //using single loop to reduce time complexity to O(1), handling lat char is same and last char is different both the cases
            // can be done with 2 Loops with less if else but time complexity will be O(N)
            //pick first item in loop increase the counter till same char comes, rest conter when next char comes
            for (int i = 0; i < item.Count; i++)
            {
            //Set first Item and increase counter
                if (i == 0)
                {
                    currentChar = item[i];
                    counter++;
                }
                else
                {
                    //if new char print and set current as new and reset counter to 1
                    if (currentChar != item[i])
                    {
                        Console.WriteLine(currentChar + " = " + counter);
                        currentChar = item[i];
                        counter = 1;
                        //If last item is different will print it as the loop will not return now
                        if (i == item.Count - 1)
                        {
                            Console.WriteLine(currentChar + " = " + counter);
                        }
                    }
                    else
                    {
                        //case is same char coming so increasing the counter
                        counter++;
                        //last item is same print it after incresing conter as loop will not return now
                        if(i == item.Count-1)
                        {
                            Console.WriteLine(currentChar + " = " + counter);
                        }
                    }
                        
                }
            }
            Console.ReadLine();
        }

        private void CountWord()
        {

        }
    }
}
