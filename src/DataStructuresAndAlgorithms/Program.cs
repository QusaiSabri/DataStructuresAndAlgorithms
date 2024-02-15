



//using DataStructuresAndAlgorithms.Arrays;


using DataStructuresAndAlgorithms.Arrays;

TestLongestConsecutive();
//TestStringsCodec();
//TestIsValidSudoku();
//void TestIsAnagram()
//{
//    var s = "anagram";
//    var t = "nagaram";
//    var result = IsAnagramSolution.IsAnagram(s, t);
//    Console.WriteLine(result);
//}
//TestTopKFrequent();
//TestGroupAnagramsWithSort();
//TestIsAnagram();
//TestTwoSum();
//TestBestTimeToBuyAndSellStock();
//TestContainsDuplicate();
//TestProductExceptSelf();
//TestMaxSubArray();

void TestLongestConsecutive()
{
    var nums = new int[] { 100, 4, 200, 1, 3, 2 };
    var result = new LongestConsecutiveSolution().LongestConsecutive(nums);
    Console.WriteLine(result);
}

void TestStringsCodec()
{
    var codec = new StringsCodec();
    var input = new List<string> { "hello", "world" };
    var encoded = codec.Encode(input);
    Console.WriteLine(encoded);
    var decoded = codec.Decode(encoded);
    Console.WriteLine(string.Join(", ", decoded));
}

void TestIsValidSudoku()
{
    var board = new char[][]
    {
        new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
        new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
        new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
        new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
        new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
        new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
        new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
        new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
        new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
    };

    var result = new IsValidSudokuSolution().IsValidSudoku(board);
    Console.WriteLine(result);
}

void TestTopKFrequent()
{
    var nums = new int[] { 1, 1, 1, 2, 2, 3 };
    var k = 2;
    var result = new TopKFrequentSolution().TopKFrequent(nums, k);
    Console.WriteLine(string.Join(", ", result));
}

void TestGroupAnagramsWithSort()
{
    var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
    List<string> string_list =
    [
        "eat",
        "tea",
        "tan",
        "ate",
        "nat",
        "bat",
    ];

    var result = new GroupAnagrams().SolveGroupAnagramsWithSort(strs);

    foreach (var group in result)
    {
        Console.WriteLine("[" + string.Join(", ", group) + "]");
    }

    var result2 = new GroupAnagrams().SolveGroupAnagramsWithFrequencyCount(strs);
    foreach (var group in result2)
    {
        Console.WriteLine("[" + string.Join(", ", group) + "]");
    }

}

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


