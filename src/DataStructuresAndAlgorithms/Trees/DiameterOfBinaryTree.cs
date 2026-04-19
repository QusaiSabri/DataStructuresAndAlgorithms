namespace DataStructuresAndAlgorithms.Trees
{
  public class DiameterOfBinaryTreeSolution
  {
    // 543. Diameter of Binary Tree
    // DFS / Recursive (O(n))
    // Input: root = [1,2,3,4,5]
    // Output: 3

    // Store the largest diameter found so far
    private int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
      // Start DFS to compute heights and update diameter
      GetHeight(root);

      // Return the largest diameter found
      return diameter;
    }

    private int GetHeight(TreeNode node)
    {
      // Null node has height 0
      if (node == null)
        return 0;

      // Get height of left subtree
      int leftHeight = GetHeight(node.left);

      // Get height of right subtree
      int rightHeight = GetHeight(node.right);

      // Diameter through this node = left height + right height
      diameter = Math.Max(diameter, leftHeight + rightHeight);

      // Return height of this node
      return 1 + Math.Max(leftHeight, rightHeight);
    }
  }
}
