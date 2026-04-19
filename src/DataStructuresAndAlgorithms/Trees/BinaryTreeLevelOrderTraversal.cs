namespace DataStructuresAndAlgorithms.Trees
{
  public class BinaryTreeLevelOrderTraversal
  {
    // 102. Binary Tree Level Order Traversal
    // BFS / Queue (O(n))
    // Input: root = [3,9,20,null,null,15,7]
    // Output: [[3],[9,20],[15,7]]
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
      // Final result list
      var result = new List<IList<int>>();

      // If tree is empty, return empty list
      if (root == null)
        return result;

      // Queue for BFS traversal
      var queue = new Queue<TreeNode>();

      // Start with the root node
      queue.Enqueue(root);

      // Process nodes level by level
      while (queue.Count > 0)
      {
        // Number of nodes at the current level
        int levelSize = queue.Count;

        // List to store current level values
        var currentLevel = new List<int>();

        // Process all nodes in this level
        for (int i = 0; i < levelSize; i++)
        {
          // Remove node from queue
          var node = queue.Dequeue();

          // Add its value to current level
          currentLevel.Add(node.val);

          // Add left child if it exists
          if (node.left != null)
            queue.Enqueue(node.left);

          // Add right child if it exists
          if (node.right != null)
            queue.Enqueue(node.right);
        }

        // Add this level to result
        result.Add(currentLevel);
      }

      return result;
    }
  }
}
