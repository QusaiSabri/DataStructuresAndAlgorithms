namespace DataStructuresAndAlgorithms.Stacks
{
    public class MinStack
    {
        // Main stack stores all values
        private readonly Stack<int> _stack = new();

        // Min stack stores the minimum value at each level
        private readonly Stack<int> _mins = new();

        public void Push(int val)
        {
            // Push value onto main stack
            _stack.Push(val);

            // If mins is empty, this val is the current min
            // Otherwise, compare val with current min
            if (_mins.Count == 0)
                _mins.Push(val);
            else
                _mins.Push(Math.Min(val, _mins.Peek()));  // Track minimum up to this point
        }

        public void Pop()
        {
            // Pop from both stacks to keep them aligned
            _stack.Pop();
            _mins.Pop();
        }

        public int Top()
        {
            // Top of main stack
            return _stack.Peek();
        }

        public int GetMin()
        {
            // Top of min stack always holds the current minimum
            return _mins.Peek();
        }
    }
}
