using DataStructuresAndAlgorithms;

int[] profits = { 1, 6, 10, 16 };
int[] weights = { 1, 2, 3, 5 };
var knapsack = new DynamicProgramming.Knapsack();

var resDP = knapsack.DP(profits, weights, 7);
var resRecWithMem = knapsack.RecursiveWithMemoization(profits, weights, 7);
var resRec = knapsack.Recursive(profits, weights, 7);

Console.WriteLine("Total profit --> " + resDP);
Console.WriteLine("Total profit --> " + resRecWithMem);
Console.WriteLine("Total profit --> " + resRec);

