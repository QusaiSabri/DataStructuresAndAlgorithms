namespace DataStructuresAndAlgorithms.Trees
{
  public class SameTree
  {
    // 100. Same Tree
    // DFS / Recursive (O(n))
    // Input: p = [1,2,3], q = [1,2,3]
    // Output: true
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
      if (p == null && q == null)
        return true;

      if (p == null || q == null)
        return false;

      return p.val == q.val &&
          IsSameTree(p.left, q.left) &&
          IsSameTree(p.right, q.right);
    }
  }
}
