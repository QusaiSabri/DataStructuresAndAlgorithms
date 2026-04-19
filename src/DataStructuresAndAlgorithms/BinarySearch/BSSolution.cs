namespace DataStructuresAndAlgorithms.BinarySearch
{
    public class BSSolution
    {

        //Given an array of integers nums which is sorted in ascending order,
        //and an integer target, write a function to search target in nums.
        //If target exists, then return its index. Otherwise, return -1.
        //You must write an algorithm with O(log n) runtime complexity.
        //Input: nums = [-1,0,3,5,9,12], target = 9
        //               _    _     _
        //Output: 4
        public static int BinarySearch(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;

            }

            return -1;
        }


        // Input: nums = [3,4,5,1,2]
        // Output: 1
        // Explanation: The original array was[1, 2, 3, 4, 5] rotated 3 times.             
        // example 2 : [11,13,15,17]
        public static int FindMinimumInRotatedSortedArray(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }

        // Search in Rotated Sorted Array
        // Input: nums = [4,5,6,7,0,1,2], target = 0
        // Output: 4
        public static int FindMinimumInRotatedSortedArray(int[] nums, int target)
        {
            // Approach: At each step you check which half is sorted,
            // then decide if the target is inside that sorted rang, if yes, search inside it,
            // otherwise search the other half.

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;

                // Check which side is sorted
                if (nums[left] <= nums[mid])
                {
                    // Left side is sorted
                    if (target >= nums[left] && target < nums[mid])
                        right = mid - 1;  // Search left half
                    else
                        left = mid + 1;   // Search right half
                }
                else
                {
                    // Right side is sorted
                    if (target > nums[mid] && target <= nums[right])
                        left = mid + 1;   // Search right half
                    else
                        right = mid - 1;  // Search left half
                }
            }

            return -1;
        }
        // Search a 2D Matrix
        // Each row is sorted, and the first integer of each row is greater than the last of the previous row.
        // Treat the matrix as a flattened sorted array and binary search in O(log(m * n)).
        // Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
        // Output: true
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            // Total number of rows
            int rows = matrix.Length;

            // Total number of columns
            int cols = matrix[0].Length;

            // Treat the matrix as a 1D sorted array → start from index 0
            int left = 0;

            // End at the last index of the "flattened" array
            int right = rows * cols - 1;

            // Standard binary search loop
            while (left <= right)
            {
                // Find middle index (safe calculation)
                int mid = left + (right - left) / 2;

                // Convert 1D index → row index
                int row = mid / cols;

                // Convert 1D index → column index
                int col = mid % cols;

                // Get value from matrix
                int value = matrix[row][col];

                // If we found the target → return true
                if (value == target)
                    return true;

                // If value is smaller → search right half
                if (value < target)
                    left = mid + 1;
                else
                    // If value is larger → search left half
                    right = mid - 1;
            }

            // Target not found
            return false;
        }

        // Koko Eating Bananas
        // Binary search on the eating speed k (1 to max pile size).
        // For each speed, calculate total hours needed. Find the minimum speed that finishes within h hours.
        // Input: piles = [3,6,7,11], h = 8
        // Output: 4
        public static int MinEatingSpeed(int[] piles, int h)
        {
            // Minimum possible speed is 1 banana per hour
            int left = 1;

            // Maximum possible speed is the largest pile (eat it in 1 hour)
            int right = piles.Max();

            // Store the best valid speed found
            int answer = right;

            // Binary search on possible eating speeds
            while (left <= right)
            {
                // Try a middle speed
                int speed = left + (right - left) / 2;

                // Track total hours needed at this speed
                double totalHours = 0;

                // Go through each pile
                foreach (int pile in piles)
                {
                    // Calculate hours for this pile using CEILING
                    // Example: pile=7, speed=3 → 7/3 = 2.33 → ceil → 3 hours
                    totalHours += Math.Ceiling((double)pile / speed);
                }

                // If we can finish within h hours, this speed works
                if (totalHours <= h)
                {
                    // Save it as a possible answer
                    answer = speed;

                    // Try to find a smaller (slower) valid speed
                    right = speed - 1;
                }
                else
                {
                    // Too slow → need to eat faster
                    left = speed + 1;
                }
            }

            // Return the smallest valid speed
            return answer;
        }
    }
}
