using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeMedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums1AsList = new List<int>(nums1);
            var nums2AsList = new List<int>(nums2);
            nums1AsList.AddRange(nums2AsList);
            nums1AsList.Sort();

            var count = nums1AsList.Count;
            if ((count & 1) !=0)
            {
                return nums1AsList[(count / 2)];
            }

            var index = (count / 2) - 1;
            return ((double)nums1AsList[index] + (double)nums1AsList[index+1])/2;
        }
    }
}
