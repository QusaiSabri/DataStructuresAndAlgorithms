namespace DataStructuresAndAlgorithms.Arrays
{
    //https://leetcode.com/problems/maximum-product-subarray/
    // Input: nums = [2,3,-2,4]
    // Output: 6
    // Explanation: [2,3] has the largest product 6.
    public class MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int currentMaxProduct = nums[0];
            int currentMinProduct = nums[0];
            int globalMaxProduct = currentMaxProduct;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    int temp = currentMaxProduct;
                    currentMaxProduct = currentMinProduct;
                    currentMinProduct = temp;
                }

                currentMaxProduct = Math.Max(nums[i], currentMaxProduct * nums[i]);
                currentMinProduct = Math.Min(nums[i], currentMinProduct * nums[i]);
                globalMaxProduct = Math.Max(currentMaxProduct, globalMaxProduct);
            }

            return globalMaxProduct;

        }
    }
}

