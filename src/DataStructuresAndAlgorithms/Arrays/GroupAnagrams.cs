
namespace DataStructuresAndAlgorithms.Arrays
{
    public class GroupAnagrams
    {
        /// <summary>
        /// Time complexity: O(NK log K), where N is the length of the input array, 
        /// and K is the maximum length of a string in the array. This is because each string is sorted individually, 
        /// and the sorting operation has a time complexity of O(K log K). 
        /// Space complexity: O(NK), as we store all the strings in the dictionary.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> SolveGroupAnagramsWithSort(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return new List<IList<string>>();

            var groups = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var sortedStr = String.Concat(str.OrderBy(c => c));

                if (!groups.ContainsKey(sortedStr))
                {
                    groups.Add(sortedStr, new List<string>());
                }

                groups[sortedStr].Add(str);
            }

            return new List<IList<string>>(groups.Values);

        }


        /// <summary>
        /// Time complexity: O(NK)
        /// Space complexity: O(NK)
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> SolveGroupAnagramsWithFrequencyCount(string[] strs)
        {
            if (strs == null || strs.Length == 0) return new List<IList<string>>();

            var groups = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                int[] count = new int[26];
                foreach (char c in str)
                {
                    count[c - 'a']++;
                }

                string key = string.Join("#", count);

                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }
                groups[key].Add(str);
            }

            return new List<IList<string>>(groups.Values);
        }
    }
}
