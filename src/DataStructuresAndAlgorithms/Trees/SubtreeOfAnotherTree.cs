namespace DataStructuresAndAlgorithms.Trees
{
  public class SubtreeOfAnotherTree
  {
    // 572. Subtree of Another Tree
    // DFS / Recursive (O(m * n))
    // Input: root = [3,4,5,1,2], subRoot = [4,1,2]
    // Output: true
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
      // If subRoot is null, it is always a subtree
      if (subRoot == null)
        return true;

      // If main tree is null but subRoot is not, impossible
      if (root == null)
        return false;

      // If trees match starting at this node, return true
      if (IsSameTree(root, subRoot))
        return true;

      // Otherwise, keep searching in left or right subtree
      return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
      // If both nodes are null, they match
      if (p == null && q == null)
        return true;

      // If only one is null, they do not match
      if (p == null || q == null)
        return false;

      // If values differ, they do not match
      if (p.val != q.val)
        return false;

      // Both current nodes match, so compare left and right children
      return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
  }
}
