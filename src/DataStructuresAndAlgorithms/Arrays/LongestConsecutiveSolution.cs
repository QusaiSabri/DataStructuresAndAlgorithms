using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class LongestConsecutiveSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            // [100,4,200,1,3,2]
            var numSet = new HashSet<int>(nums);
            var longestStreak = 0;

            foreach (var num in numSet)
            {
                if(!numSet.Contains(num - 1))
                {
                    var currentNum = num;
                    var currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentStreak += 1;
                        currentNum++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
