namespace DataStructuresAndAlgorithms.Arrays
{
    //Given an integer array nums, find the subarray with the largest sum, and return its sum. -->https://leetcode.com/problems/maximum-subarray/

    /// <summary>
    /// <para>Example:</para>
    /// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
    //  Output: 6
    //  Explanation: The subarray[4, -1, 2, 1] has the largest sum 6.
    /// </summary>
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var maxSub = nums[0];
            var curSum = 0;

            foreach (var num in nums)
            {
                //If the curSum is negative, we have to reset it to 0. This is because a negative curSum would decrease the sum of a future subarray.
                if (curSum < 0)
                    curSum = 0;
                curSum += num;
                maxSub = Math.Max(curSum, maxSub);
            }

            return maxSub;
        }
    }
}
