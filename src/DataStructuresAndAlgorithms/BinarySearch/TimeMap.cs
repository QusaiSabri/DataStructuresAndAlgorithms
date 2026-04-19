namespace DataStructuresAndAlgorithms.BinarySearch
{
    // Time Based Key-Value Store
    // Stores multiple values for the same key at different timestamps.
    // Set is O(1), Get is O(log n) via binary search on the timestamp list.
    public class TimeMap
    {
        // Maps each key to a chronologically-ordered list of (timestamp, value) pairs.
        // Order is maintained for free because Set is called with increasing timestamps per key.
        private readonly Dictionary<string, List<(int ts, string val)>> _store = new();

        public void Set(string key, string value, int timestamp)
        {
            // Try to grab the existing list for this key; if none exists, create and register one.
            if (!_store.TryGetValue(key, out var list))
            {
                // First time seeing this key — initialize its history list.
                list = new List<(int, string)>();
                // Register the new list in the dictionary so future Sets/Gets find it.
                _store[key] = list;
            }
            // Append the new entry; since timestamps are strictly increasing, the list stays sorted.
            list.Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            // If the key was never set, there's nothing to return per the problem spec.
            if (!_store.TryGetValue(key, out var list))
                return "";

            // Standard binary search bounds over the key's history.
            int left = 0, right = list.Count - 1;
            // Tracks the best candidate index found so far; -1 means "nothing valid yet."
            int result = -1;

            // Classic binary search loop — continues while the search window is non-empty.
            while (left <= right)
            {
                // Overflow-safe midpoint calculation (avoids (left + right) / 2 overflow).
                int mid = left + (right - left) / 2;

                // If this entry's timestamp doesn't exceed the query, it's a valid candidate.
                if (list[mid].ts <= timestamp)
                {
                    // Save it — but keep searching to the right in case a later entry also qualifies.
                    result = mid;
                    // Shrink the window to everything strictly after mid.
                    left = mid + 1;
                }
                else
                {
                    // mid's timestamp is too large — discard mid and everything after it.
                    right = mid - 1;
                }
            }

            // If no entry qualified (all timestamps were greater than the query), return "".
            // Otherwise return the value at the best candidate index we recorded.
            return result == -1 ? "" : list[result].val;
        }
    }
}
