using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_EnumerableMagic25_TakeFirstNElements
{
    class Program
    {
        static void Main()
        {
            // https://www.codewars.com/kata/545afd0761aa4c3055001386/
            List<int> output = Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3).ToList();
            output.ForEach(x => Console.WriteLine(x));
        }

        // First solution:
        public static int[] Take(int[] arr, int n)
        {
            return arr.Take(n).ToArray();
        }
    }
}
