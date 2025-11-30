namespace DataStructuresAndAlgorithms.TwoPointers
{
    public class TwoPointers
    {
        // Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        // Note: For the purpose of this problem, we define empty string as valid palindrome.
        // Example 1: Input: s = "A man, a plan, a canal: Panama"
        // Output: true
        // Explanation: "amanaplanacanalpanama" is a palindrome.
        // Time complexity: O(n) where n is the length of the string.
        // Space complexity: O(1) since we use a constant amount of space regardless of the input size.
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Move left pointer to next valid character
                while (left < right && !char.IsLetterOrDigit(s[left]))
                    left++;

                // Move right pointer to previous valid character
                while (left < right && !char.IsLetterOrDigit(s[right]))
                    right--;

                // Compare characters (case-insensitive)
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }


        // Two Sum II - Input Array Is Sorted
        // Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        // Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.length.
        // The tests are generated such that there is exactly one solution. You may not use the same element twice.
        // Your solution must use only constant extra space.
        // Example 1: Input: numbers = [2,7,11,15], target = 9
        // Output: [1,2]

        public static int[] TwoSum(int[] numbers, int target)
        {
            //[2,7,11,15]
            // L       R

            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var sum = numbers[left] + numbers[right];

                if (sum == target)
                    return new int[2] { left + 1, right + 1 };

                if (sum < target && left < right)
                {
                    left++;
                }

                if (sum > target && left < right)
                {
                    right--;
                }
            }

            // Return an empty array if no solution is found.
            return [];
        }

        public static List<List<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();

            if (nums == null || nums.Length < 3)
                return result;

            Array.Sort(nums);

            // [-4, -1, -1, 0, 1, 2]
            //       i   L        R
            //       --  --       --

            //Loop through each number as a potential first element of the triplet.
            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicates for first number
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                //For each number, we run a two pointer search(left, right) to find pairs that sum to - nums[i].
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        left++;
                        right--;

                        // Skip duplicates for the second number
                        while (left < right && nums[left] == nums[left - 1])
                            left++;

                        // Skip duplicates for the third number
                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                    else if (sum < 0)
                    {
                        left++;     // Need a bigger sum
                    }
                    else
                    {
                        right--;    // Need a smaller sum
                    }
                }
            }

            return result;
        }

        //Container With Most Water
        //height = [1,7,2,5,4,7,3,6]
        public static int MaxArea(int[] heights)
        {
            var maxArea = 0;
            var left = 0;
            var right = heights.Length - 1;

            while (left < right)
            {
                var h = Math.Min(heights[left], heights[right]);
                var w = right - left;
                maxArea = Math.Max(maxArea, h * w);

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }

        // Trapping Rain Water
        public static int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            // Track the highest wall seen so far from the left
            int leftMax = 0;

            // Track the highest wall seen so far from the right
            int rightMax = 0;

            // Total trapped water
            int water = 0;

            // Process from both ends until pointers meet
            while (left < right)
            {
                // Always move the pointer with the smaller height
                // because water level is limited by the shorter side
                if (height[left] < height[right])
                {
                    // If current left height is a new maximum, update leftMax
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        // Otherwise, water is leftMax minus current height
                        water += leftMax - height[left];
                    }

                    // Move left pointer inward
                    left++;
                }
                else
                {
                    // If current right height is a new maximum, update rightMax
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        // Otherwise, water is rightMax minus current height
                        water += rightMax - height[right];
                    }

                    // Move right pointer inward
                    right--;
                }
            }

            // Total trapped water accumulated
            return water;
        }


        // Buy and Sell Stock
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (var price in prices)
            {
                if (price < minPrice)
                    minPrice = price; // update the lowest price seen so far
                else
                    maxProfit = Math.Max(maxProfit, price - minPrice); // calculate profit if sold today
            }

            return maxProfit;
        }
    }
}
