namespace DataStructuresAndAlgorithms.Arrays
{
    /// <summary>
    /// Two Sum --> https://leetcode.com/problems/two-sum/
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //
    // Example 1:
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public static class TwoSum
    {
        /// <summary>
        /// Solves the Two Sum problem using a hash map.
        /// <para>Time complexity: O(n), where n is the number of elements in the array, because we make a single pass through the array.</para>
        /// <para>Space complexity: O(n), because in the worst case, we would need to store all numbers in the hash map.</para>
        /// </summary>
        public static int[] SolveWithHashMap(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[2] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            throw new InvalidOperationException("No two sum solution");
        }
    }
}
