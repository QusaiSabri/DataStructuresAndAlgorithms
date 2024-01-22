



using DataStructuresAndAlgorithms.Arrays;
//void TestIsAnagram()
//{
//    var s = "anagram";
//    var t = "nagaram";
//    var result = IsAnagramSolution.IsAnagram(s, t);
//    Console.WriteLine(result);
//}

//TestIsAnagram();
TestTwoSum();
//TestBestTimeToBuyAndSellStock();
//TestContainsDuplicate();
//TestProductExceptSelf();
//TestMaxSubArray();




//void TestMaxSubArray()
//{
//    var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
//    var result = MaximumSubarray.MaxSubArray(nums);
//    Console.WriteLine(string.Join(", ", result));
//}
//void TestProductExceptSelf()
//{
//    var nums = new int[] { 1, 2, 3, 4 };
//    var result = ProductofArrayExceptSelf.ProductExceptSelf(nums);
//    Console.WriteLine(string.Join(", ", result));
//}
//void TestContainsDuplicate()
//{
//    var nums = new int[] { 1, 2, 3, 1 };
//    var result = ContainsDuplicate.CheckForDuplicates(nums);
//    Console.WriteLine(string.Join(", ", result));

//}
//void TestBestTimeToBuyAndSellStock()
//{
//    var prices = new int[] { 7, 1, 5, 3, 6, 4 };
//    var result = BestTimeToBuyAndSellStock.MaxProfit(prices);
//    Console.WriteLine(string.Join(", ", result));

//}
void TestTwoSum()
{
    // Test case
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;

    var result = TwoSum.SolveWithHashMap(nums, target);
    Console.WriteLine(string.Join(", ", result));
}
//void TestKnapsack()
//{
//    int[] profits = { 1, 6, 10, 16 };
//    int[] weights = { 1, 2, 3, 5 };
//    var knapsack = new DynamicProgramming.Knapsack();

//    var resDP = knapsack.DP(profits, weights, 7);
//    var resRecWithMem = knapsack.RecursiveWithMemoization(profits, weights, 7);
//    var resRec = knapsack.Recursive(profits, weights, 7);

//    Console.WriteLine("Total profit --> " + resDP);
//    Console.WriteLine("Total profit --> " + resRecWithMem);
//    Console.WriteLine("Total profit --> " + resRec);

//}


