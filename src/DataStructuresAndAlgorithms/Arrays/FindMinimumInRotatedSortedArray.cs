using System;
using System.Numerics;

namespace DataStructuresAndAlgorithms.Arrays
{
    //Example [4,5,6,7,0,1,2]
    //Example [0,1,2,4,5,6,7]
    public class FindMinimumInRotatedSortedArray
	{
        /// <summary>
        /// Solves the "Find Minimum in Rotated Sorted Array" problem.
        /// <para>Time Complexity: O(log n), because we are using a binary search to halve the search space at every step.</para>
        /// <para>Space Complexity: O(1), since we are using a constant amount of space.</para>
        /// </summary>
        public int SolveWithBinarySearch(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while(left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                } else
                {
                    right = mid;
                }

            }

            return nums[left];
        }
    }
}

