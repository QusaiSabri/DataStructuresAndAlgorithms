using System;
namespace DataStructuresAndAlgorithms.Arrays
{
	public static class ContainsDuplicate
	{
        /// <summary>
        /// Checks if the input array contains any duplicates.
        /// <para>Time complexity: O(n), where n is the number of elements in the array, because we make a single pass through the array.</para>
        /// <para>Space complexity: O(n), because in the worst case, we would need to store all unique elements in the hash set.</para>
        /// </summary>
        public static bool CheckForDuplicates(int[] nums)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Add(nums[i]))
                {
                    return true;
                }
            }

            return false;
        }

    }
}

