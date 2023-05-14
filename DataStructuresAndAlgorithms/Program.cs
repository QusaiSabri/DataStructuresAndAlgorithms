using DataStructuresAndAlgorithms;
using DataStructuresAndAlgorithms.Arrays;


TestTwoSum();


static void TestTwoSum()
{
    // Test case
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;

    var result = TwoSum.SolveWithHashMap(nums, target);
    Console.WriteLine(string.Join(", ", result));
}

static void TestKnapsack()
{
    int[] profits = { 1, 6, 10, 16 };
    int[] weights = { 1, 2, 3, 5 };
    var knapsack = new DynamicProgramming.Knapsack();

    var resDP = knapsack.DP(profits, weights, 7);
    var resRecWithMem = knapsack.RecursiveWithMemoization(profits, weights, 7);
    var resRec = knapsack.Recursive(profits, weights, 7);

    Console.WriteLine("Total profit --> " + resDP);
    Console.WriteLine("Total profit --> " + resRecWithMem);
    Console.WriteLine("Total profit --> " + resRec);

}


