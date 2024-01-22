namespace DataStructuresAndAlgorithms.Arrays
{
    public static class IsAnagramSolution
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] counts = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
                counts[t[i] - 'a']--;
            }

            return counts.All(counts => counts == 0);
        }
    }
}
