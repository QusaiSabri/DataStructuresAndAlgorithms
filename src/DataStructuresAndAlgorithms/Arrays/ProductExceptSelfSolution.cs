namespace DataStructuresAndAlgorithms.Arrays
{
    public class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] answer = new int[length];

            // Initialize the first element to 1 since there are no elements to the left of the first element
            answer[0] = 1;
            // Left to right pass
            for (int i = 1; i < length; i++)
            {
                answer[i] = nums[i - 1] * answer[i - 1];
                // "answer" array after each iteration:
                // Iteration 1: answer[1] = 1 * 1 = 1 -> [1, 1, 0, 0]
                // Iteration 2: answer[2] = 2 * 1 = 2 -> [1, 1, 2, 0]
                // Iteration 3: answer[3] = 3 * 2 = 6 -> [1, 1, 2, 6]
            }

            // R represents the product of all elements to the right
            int R = 1;
            for (int i = length - 1; i >= 0; i--)
            {
                // Multiplying by R gives us the product of all elements to the right of i
                answer[i] = answer[i] * R;
                R *= nums[i];
                // R and answer[i] change in each iteration:
                // Iteration 1 (from the end): R = 1, answer[3] = 6 * 1 = 6 -> [1, 1, 2, 6]
                // Iteration 2: R = 4, answer[2] = 2 * 4 = 8 -> [1, 1, 8, 6]
                // Iteration 3: R = 12, answer[1] = 1 * 12 = 12 -> [1, 12, 8, 6]
                // Finally, R = 24 (not used further), final answer = [1, 12, 8, 6]
            }

            return answer;
        }
    }
}