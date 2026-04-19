namespace DataStructuresAndAlgorithms.Trees
{
  public class CountGoodNodesInBinaryTree
  {
    // 1448. Count Good Nodes in Binary Tree
    // DFS / Recursive (O(n))
    // Input: root = [3,1,4,3,null,1,5]
    // Output: 4
    public int GoodNodes(TreeNode root)
    {
      // Start DFS with root value as the initial maximum
      return CountGoodNodes(root, root.val);
    }

    private int CountGoodNodes(TreeNode node, int maxSoFar)
    {
      // Null node contributes 0 good nodes
      if (node == null)
        return 0;

      // Check if current node is good
      int count = node.val >= maxSoFar ? 1 : 0;

      // Update max value for the path going down
      int newMax = Math.Max(maxSoFar, node.val);

      // Count good nodes in left subtree
      count += CountGoodNodes(node.left, newMax);

      // Count good nodes in right subtree
      count += CountGoodNodes(node.right, newMax);

      // Return total count from this subtree
      return count;
    }
  }
}
