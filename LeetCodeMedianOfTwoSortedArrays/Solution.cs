using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeMedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var count = nums1.Length + nums2.Length;
            var nums = new int[(count/2)+1];
            var mergeIndex = 0;
            var stopAt = (count / 2)+1;
            var lindex = 0;
            var rindex = 0;

            for (;;)
            {
                if (mergeIndex >= stopAt)
                    break;

                if (lindex < nums1.Length) 
                {
                    if (rindex == nums2.Length || nums1[lindex] <= nums2[rindex])
                    {
                        nums[mergeIndex++] = nums1[lindex++];
                        continue;
                    }
                }
                
                if (rindex < nums2.Length)
                {
                    nums[mergeIndex++] = nums2[rindex++];
                    continue;
                }

                break;
            }
            
            if ((count & 1) !=0)
            {
                return nums[(count / 2)];
            }

            var index = (count / 2) - 1;
            return (nums[index] + (double)nums[index +1])/2;
        }
    }
}
