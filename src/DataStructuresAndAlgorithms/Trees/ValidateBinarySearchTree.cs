namespace DataStructuresAndAlgorithms.Trees
{
  public class ValidateBinarySearchTree
  {
    // 98. Validate Binary Search Tree
    // DFS / Recursive with range check (O(n))
    // Input: root = [2,1,3]
    // Output: true
    public bool IsValidBST(TreeNode root)
    {
      return Validate(root, long.MinValue, long.MaxValue);
    }

    private bool Validate(TreeNode node, long min, long max)
    {
      // Empty subtree is vacuously valid.
      if (node == null) return true;

      // Node's value must strictly fall within the allowed range.
      if (node.val <= min || node.val >= max) return false;

      // Left subtree: same min, but max becomes current node's value.
      // Right subtree: same max, but min becomes current node's value.
      return Validate(node.left, min, node.val)
          && Validate(node.right, node.val, max);
    }
  }
}
