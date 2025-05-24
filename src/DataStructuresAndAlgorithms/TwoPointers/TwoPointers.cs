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
            if (s == null || s.Length == 0)
            {
                return true;
            }

            s = s.ToLower();

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (s[left] != s[right])
                {
                    return false;
                }

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
            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            // Return an empty array if no solution is found.
            return new int[] { };
        }

        public static List<List<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();

            Array.Sort(nums);
            // [-4, -1, -1, 0, 1, 2]
            //       i   L        R
            //       --  --       --
            for (var i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicates for the first number
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Skip duplicates for left and right
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right -1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
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

            while(left < right)
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
            var left = 0;
            var right = height.Length - 1;
            var leftMax = 0;
            var rightMax = 0;
            var water = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        water += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        water += rightMax - height[right];
                    }
                    right--;
                }
            }
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
