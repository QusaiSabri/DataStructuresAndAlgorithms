namespace DataStructuresAndAlgorithms.Arrays
{
    public class ProductofArrayExceptSelf
    {
        /// <summary>
        /// <para>Time complexity is O(n), where n is the number of elements in the array. This is because we make two passes through the array: one to calculate the product from the left and one to calculate the product from the right.</para>
        /// <para>Space complexity is O(1), if we don't count the space for the output array. This is because we do not use any additional space that grows with the size of the input array.</para>
        /// </summary>
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];

            // Calculate the product of all numbers to the left of each index
            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                res[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // Calculate the product of all numbers to the right of each index
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                res[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return res;
        }

    }
}

