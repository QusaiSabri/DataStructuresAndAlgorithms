namespace DataStructuresAndAlgorithms.SlidingWindow
{
  public class PermutationInString
  {
    // 567. Permutation in String
    // Sliding Window + Frequency Count (O(n))
    // Input: s1 = "ab", s2 = "eidbaooo"
    // Output: true
    public bool CheckInclusion(string s1, string s2)
    {
      // Can't fit s1 inside s2 — no permutation possible.
      if (s1.Length > s2.Length) return false;

      // Frequency profiles for s1 and the current window in s2.
      int[] s1Count = new int[26];
      int[] windowCount = new int[26];

      // Build the initial window: first s1.Length chars of both strings.
      for (int i = 0; i < s1.Length; i++)
      {
        s1Count[s1[i] - 'a']++;
        windowCount[s2[i] - 'a']++;
      }

      // Check if the starting window already matches.
      if (Matches(s1Count, windowCount)) return true;

      // Slide the window one char at a time across the rest of s2.
      for (int right = s1.Length; right < s2.Length; right++)
      {
        // Add the new char on the right.
        windowCount[s2[right] - 'a']++;
        // Remove the char that fell off the left.
        windowCount[s2[right - s1.Length] - 'a']--;

        if (Matches(s1Count, windowCount)) return true;
      }

      return false;
    }

    private bool Matches(int[] a, int[] b)
    {
      for (int i = 0; i < 26; i++)
        if (a[i] != b[i]) return false;
      return true;
    }
  }
}
