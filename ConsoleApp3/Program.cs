using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 10, 3, 4, 9, 5, 6, 8, 7, 8, 9, 10 };
            List<int> list2 = list1.OrderBy(x => x).Distinct().ToList();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
