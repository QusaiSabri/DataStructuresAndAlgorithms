using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class TopKFrequentSolution
    {

        /// <summary>
        /// Input: nums = [1,1,1,2,2,3], k = 2
        //  Output: [1,2]
        /// Finds the top K frequent elements in an array. Uses a dictionary for frequency counting and a priority queue to keep the top K elements.
        /// <para>Time complexity: O(N log K) where N is the number of elements in the array.</para>
        /// <para>Space complexity: O(N + K) where N is for the frequency map that stores each unique element and its count and K for the priority queue.</para>
        /// </summary>


        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0) 
                return new int[0];

            var result = new int[k];
            var frequencyMap = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if (!frequencyMap.ContainsKey(num))
                {
                    frequencyMap.Add(num, 1);
                }
                else
                {
                    frequencyMap[num]++;
                }
            }

            var priortyQueue = new PriorityQueue<int, int>(new Comparer());

            foreach (var (num, count) in frequencyMap)
            {
                priortyQueue.Enqueue(num, count);

                if (priortyQueue.Count > k)
                {
                    priortyQueue.Dequeue();
                }
            }

            for (int i = 0; i < k; i++)
            {
                result[i] = priortyQueue.Dequeue();
            }

            return result;
        }
    }

    internal class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return (x.CompareTo(y));
        }
    }
}
