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
    }
}
