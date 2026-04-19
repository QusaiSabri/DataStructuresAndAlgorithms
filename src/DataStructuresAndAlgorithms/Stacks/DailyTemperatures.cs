namespace DataStructuresAndAlgorithms.Stacks
{
    public class DailyTemperaturesSolution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];
            var stack = new Stack<int>(); // stores indices

            for (int currentDay = 0; currentDay < temperatures.Length; currentDay++)
            {
                // While current day is warmer than the day on top of the stack
                while (stack.Count > 0 && temperatures[currentDay] > temperatures[stack.Peek()])
                {
                    int previousDay = stack.Pop();
                    result[previousDay] = currentDay - previousDay;
                }

                // Put current day's index on the stack
                stack.Push(currentDay);
            }

            return result;
        }
    }
}
