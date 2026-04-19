namespace DataStructuresAndAlgorithms.Trees
{
  public class InvertBinaryTree
  {
    // 226. Invert Binary Tree
    // DFS / Recursive swap (O(n))
    // Input: root = [4,2,7,1,3,6,9]
    // Output: [4,7,2,9,6,3,1]
    public TreeNode InvertTree(TreeNode root)
    {
      if (root == null)
        return null;

      var tempLeft = root.left;
      root.left = root.right;
      root.right = tempLeft;

      InvertTree(root.left);
      InvertTree(root.right);

      return root;
    }
  }
}
