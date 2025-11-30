using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SlidingWindow
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        //Sliding Window + HashSet (O(n))
        //s = "abcabcbb"
        //     __
        public int LengthOfLongestSubstring(string s)
        {
            // Set to store characters currently inside our sliding window
            var window = new HashSet<char>();

            int left = 0;          // Left pointer (start of window)
            int maxLength = 0;     // Track the longest valid window

            // Right pointer moves one step at a time through the string
            for (int right = 0; right < s.Length; right++)
            {
                // If s[right] is already in the window, shrink from the left
                while (window.Contains(s[right]))
                {
                    window.Remove(s[left]);   // Remove the leftmost char
                    left++;                   // Move left pointer to the right
                }

                // Now s[right] is safe to add (no duplicates in window)
                window.Add(s[right]);

                // Update result: window size = right - left + 1
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

    }
}
