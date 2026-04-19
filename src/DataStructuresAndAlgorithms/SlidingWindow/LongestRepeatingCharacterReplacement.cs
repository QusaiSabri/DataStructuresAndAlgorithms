namespace DataStructuresAndAlgorithms.SlidingWindow
{
  public class LongestRepeatingCharacterReplacement
  {
    // 424. Longest Repeating Character Replacement
    // Sliding Window (O(n))
    // Input: s = "AABABBA", k = 1
    // Output: 4
    public int CharacterReplacement(string s, int k)
    {
      // Frequency of each uppercase letter currently inside the window.
      int[] charFrequency = new int[26];

      int left = 0;
      int mostFrequentCharCount = 0;   // Highest single-letter frequency seen in any window so far.
      int longestValidWindow = 0;

      for (int right = 0; right < s.Length; right++)
      {
        // Add the new character to the window's frequency count.
        charFrequency[s[right] - 'A']++;

        // Track the most frequent char's count across all windows we've considered.
        mostFrequentCharCount = Math.Max(mostFrequentCharCount, charFrequency[s[right] - 'A']);

        // charsToReplace = window size - count of the dominant char.
        // If that exceeds k, we'd need too many replacements — shrink from the left.
        int windowSize = right - left + 1;
        while (windowSize - mostFrequentCharCount > k)
        {
          charFrequency[s[left] - 'A']--;
          left++;
          windowSize = right - left + 1;
        }

        // Window is valid; update our best.
        longestValidWindow = Math.Max(longestValidWindow, windowSize);
      }

      return longestValidWindow;
    }
  }
}
