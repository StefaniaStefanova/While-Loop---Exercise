namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int stepsEveryDay = 10000;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    steps += stepsToHome;
                    break; // Exiting the loop when going home
                }

                int currentSteps = int.Parse(input);
                steps += currentSteps;

                if (steps >= stepsEveryDay)
                {
                    int stepsOverGoal = steps - stepsEveryDay;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOverGoal} steps over the goal!");
                    return;
                }
            }

            if (steps < stepsEveryDay)
            {
                int diff = stepsEveryDay - steps;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}