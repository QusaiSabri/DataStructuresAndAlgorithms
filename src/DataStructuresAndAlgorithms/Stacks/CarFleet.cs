namespace DataStructuresAndAlgorithms.Stacks
{
    public class CarFleetSolution
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            // Number of cars
            int n = position.Length;

            // Pair each car's position with its speed
            var cars = new (int position, int speed)[n];

            // Fill the array with (position, speed)
            for (int i = 0; i < n; i++)
            {
                cars[i] = (position[i], speed[i]);
            }

            // Sort cars by position descending (closest to target first)
            Array.Sort(cars, (a, b) => b.position.CompareTo(a.position));

            // Count how many fleets we form
            int fleets = 0;

            // Track the slowest (latest) arrival time to the target so far
            double slowestArrivalTimeToTarget = 0;

            // Go through each car from closest → farthest
            foreach (var car in cars)
            {
                // Calculate how long this car takes to reach the target
                double timeToTarget = (double)(target - car.position) / car.speed;

                // If this car takes longer than the fleet ahead,
                // it cannot catch up → forms a new fleet
                if (timeToTarget > slowestArrivalTimeToTarget)
                {
                    fleets++; // new fleet
                    slowestArrivalTimeToTarget = timeToTarget; // update slowest arrival time
                }
                // Otherwise, it joins the existing fleet (no update needed)
            }

            // Return total fleets
            return fleets;
        }
    }
}
