namespace DataStructuresAndAlgorithms.Trees
{
  public class BalancedBinaryTree
  {
    // 110. Balanced Binary Tree
    // DFS / Recursive (O(n))
    // Input: root = [3,9,20,null,null,15,7]
    // Output: true
    public bool IsBalanced(TreeNode root)
    {
      // If GetHeight returns -1, the tree is not balanced
      return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode node)
    {
      // Null node has height 0
      if (node == null)
        return 0;

      // Get height of left subtree
      int leftHeight = GetHeight(node.left);

      // If left subtree is already unbalanced, stop early
      if (leftHeight == -1)
        return -1;

      // Get height of right subtree
      int rightHeight = GetHeight(node.right);

      // If right subtree is already unbalanced, stop early
      if (rightHeight == -1)
        return -1;

      // If height difference is more than 1, this node is unbalanced
      if (Math.Abs(leftHeight - rightHeight) > 1)
        return -1;

      // Otherwise return this node's height
      return 1 + Math.Max(leftHeight, rightHeight);
    }
  }
}
