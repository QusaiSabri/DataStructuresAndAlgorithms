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
            // We need an array to store the final result
            var result = new int[nums.Length];

            // First pass: build prefix products (product of all elements before the index)
            int prefixProduct = 1;                    // Start with 1 because product identity is 1
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefixProduct;           // At index i, store product of all elements before i
                prefixProduct *= nums[i];            // Update prefix to include nums[i] for the next index
            }

            // Second pass: build suffix products (product of all elements after the index)
            int suffixProduct = 1;                    // Reset to 1 for the suffix side
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= suffixProduct;          // Multiply existing prefix with suffix to get final answer
                suffixProduct *= nums[i];            // Update suffix to include nums[i] for the previous index
            }

            // Return the final result where each index has product of all except self
            return result;
        }
    }
}

