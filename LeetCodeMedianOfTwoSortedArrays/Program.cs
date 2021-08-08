using System;
using System.Diagnostics;

namespace LeetCodeMedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            double answer = solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            Debug.Assert(answer == 2);

            answer = solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
            Debug.Assert(answer == 2.5);

        }
    }
}
