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
    }
}
