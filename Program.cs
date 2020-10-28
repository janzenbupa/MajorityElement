using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(majorElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        static int majorElement(int[] nums)
        {
            var x = nums.GroupBy(i => i).OrderByDescending(i => i.Count()).Select(i => i.Key);

            return x.ElementAt(0);
        }
    }
}
