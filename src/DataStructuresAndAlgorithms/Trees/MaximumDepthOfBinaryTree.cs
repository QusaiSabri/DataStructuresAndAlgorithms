namespace DataStructuresAndAlgorithms.Trees
{
  public class MaximumDepthOfBinaryTree
  {
    // 104. Maximum Depth of Binary Tree
    // DFS / Recursive (O(n))
    // Input: root = [3,9,20,null,null,15,7]
    // Output: 3
    public int MaxDepth(TreeNode root)
    {
      // If the node is null, depth is 0
      if (root == null)
        return 0;

      // Recursively find depth of left subtree
      int leftDepth = MaxDepth(root.left);

      // Recursively find depth of right subtree
      int rightDepth = MaxDepth(root.right);

      // Current node adds 1 to the deeper side
      return 1 + Math.Max(leftDepth, rightDepth);
    }
  }
}
