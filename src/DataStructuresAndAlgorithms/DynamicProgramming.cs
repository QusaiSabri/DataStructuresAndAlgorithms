using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class DynamicProgramming
    {
        public class Knapsack
        {
            /// <summary>
            /// Bottom-up Dynamic Programming (No recursive calls)
            /// </summary>
            /// <param name="profits"></param>
            /// <param name="weights"></param>
            /// <param name="capacity"></param>
            /// <returns></returns>
            public int DP(int[] profits, int[] weights, int capacity)
            {
                //base case
                if (capacity == 0 || profits.Length == 0 || weights.Length != profits.Length)
                    return 0;

                var n = profits.Length;
                var dp = new int[n, capacity + 1];
                
                // Only one weight? then take it if it's <= capacity
                for (int c = 0; c <= capacity; c++)
                {
                    if (weights[0] <= c)
                        dp[0, c] = profits[0];
                }

                // process all sub-arrays for all the capacities
                for (int i = 1; i < n; i++)
                {
                    for (int c = 1; c <= capacity; c++)
                    {
                        var profit1 = 0;
                        var profit2 = 0;

                        // include the item, if it is not more than the capacity
                        if (weights[i] <= c)
                            profit1 = profits[i] + dp[i - 1, c - weights[i]];
                        // exclude the item
                        profit2 = dp[i - 1, c];

                        //Take Maximum
                        dp[i, c] = Math.Max(profit1, profit2);
                    }
                }

                return dp[n - 1, capacity];
            }
        


        /// <summary>
        /// Top-down Dynamic Programming with Memoization
        /// A smarter recursive
        /// </summary>
        /// <param name="profits"></param>
        /// <param name="weights"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int RecursiveWithMemoization(int[] profits, int[] weights, int capacity)
            {
                // TODO: Write your code here
                var dp = new int[profits.Length, capacity + 1];
                return KnapsackRecursive(capacity, 0);

                int KnapsackRecursive(int capacity, int curIndex)
                {
                    if (capacity <= 0 || curIndex >= profits.Length)
                        return 0;

                    // if we have already solved a similar problem, return the result from memory
                    if (dp[curIndex, capacity] != 0)
                    {
                        return dp[curIndex, capacity];
                    }


                    var profit1 = 0;
                    var profit2 = 0;
                    int itemWeight = weights[curIndex];
                    //I have two options
                    //Include the item and exclude the item, do both:
                    //1:
                    //If I include the item then i have to calculate the profit and the new capacity
                    if (itemWeight <= capacity)
                    {
                        profit1 = profits[curIndex] + KnapsackRecursive(capacity - itemWeight, curIndex + 1);
                    }

                    //2:
                    profit2 = KnapsackRecursive(capacity, curIndex + 1);


                    dp[curIndex, capacity] = Math.Max(profit1, profit2);

                    return dp[curIndex, capacity];
                }
        }
        
        /// <summary>
        /// Recursive approach(No dp)
        /// </summary>
        /// <param name="profits"></param>
        /// <param name="weights"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>      
            public int Recursive(int[] profits, int[] weights, int capacity)
            {
                // TODO: Write your code here
                return KnapsackRecursive(capacity, 0);

                int KnapsackRecursive(int capacity, int curIndex)
                {
                    if (capacity <= 0 || curIndex >= profits.Length)
                        return 0;

                    var profit1 = 0;
                    var profit2 = 0;
                    int itemWeight = weights[curIndex];
                    //I have two options
                    //Include the item and exclude the item, do both:
                    //1:
                    //If I include the item then i have to calculate the profit and the new capacity
                    if (itemWeight <= capacity)
                    {
                        profit1 = profits[curIndex] + KnapsackRecursive(capacity - itemWeight, curIndex + 1);
                    }

                    //2:
                    profit2 = KnapsackRecursive(capacity, curIndex + 1);



                    return Math.Max(profit1, profit2);
                }
            }
        }
    }
}
