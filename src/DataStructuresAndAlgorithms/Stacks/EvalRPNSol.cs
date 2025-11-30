namespace DataStructuresAndAlgorithms.Stacks
{
    public class EvalRPNSol
    {
        public int EvalRPN(string[] tokens)
        {
            // Stack to store operands
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                // If it's a number, push it to the stack
                if (int.TryParse(token, out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    // Pop two operands (order matters!)
                    int right = stack.Pop();   // second operand
                    int left = stack.Pop();    // first operand

                    // Apply the operator
                    int result = token switch
                    {
                        "+" => left + right,
                        "-" => left - right,
                        "*" => left * right,
                        "/" => left / right,   // integer division as per problem
                        _ => throw new InvalidOperationException("Invalid operator")
                    };

                    // Push result back on stack
                    stack.Push(result);
                }
            }

            // Final result is the only value left
            return stack.Pop();
        }
    }
}
