namespace DataStructuresAndAlgorithms.Trees
{
  public class LowestCommonAncestorBST
  {
    // 235. Lowest Common Ancestor of a Binary Search Tree
    // Iterative (O(h) time, O(1) space)
    // Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
    // Output: 6
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      // Start from the root
      TreeNode current = root;

      // Keep moving until we find the split point
      while (current != null)
      {
        // If both p and q are smaller, LCA must be in the left subtree
        if (p.val < current.val && q.val < current.val)
        {
          current = current.left;
        }
        // If both p and q are bigger, LCA must be in the right subtree
        else if (p.val > current.val && q.val > current.val)
        {
          current = current.right;
        }
        else
        {
          // We found the split point:
          // either p and q are on different sides,
          // or one of them is the current node
          return current;
        }
      }

      return null;
    }

    // Recursive version (O(h) time, O(h) space for call stack)
    public TreeNode LowestCommonAncestorRecursive(TreeNode root, TreeNode p, TreeNode q)
    {
      if (p.val < root.val && q.val < root.val)
        return LowestCommonAncestorRecursive(root.left, p, q);

      if (p.val > root.val && q.val > root.val)
        return LowestCommonAncestorRecursive(root.right, p, q);

      return root;
    }
  }
}
