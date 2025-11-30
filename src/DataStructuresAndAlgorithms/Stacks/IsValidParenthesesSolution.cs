
namespace DataStructuresAndAlgorithms.StackSolution
{
    public class IsValidParenthesesSolution
    {
        public bool IsValidParentheses(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(') stack.Push(')');
                else if (c == '{') stack.Push('}');
                else if (c == '[') stack.Push(']');
                else
                {
                    if (stack.Count == 0 || c != stack.Pop())
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
/*
|    |
|  ] |
|  } |
|  ) |
|____|
*/