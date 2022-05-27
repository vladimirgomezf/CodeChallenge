using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 10, 3, 4, 9, 5, 6, 8, 7, 8, 9, 10 };//correct output
            removeDuplicate(list1);
            Console.WriteLine();
            list1 = new List<int> { 1, 2, 10, 3, 4, 9, 5, 6, 8, 7, 8, 9 };//wrong output, check example
            removeDuplicate(list1);
        }
        static void removeDuplicate(List<int> list1)
        {
            foreach (var item in list1)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            for (int i = list1.Count-1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list1[i] == list1[j])
                    {
                        list1.RemoveAt(j);
                        i--;
                    }
                }
            }

            foreach (var item in list1)
            {
                Console.Write(item + ",");
            }
        }
    }
}
