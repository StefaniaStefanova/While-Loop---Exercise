namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendDays = 0;

            while (availableMoney < tripCost && spendDays < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    availableMoney += amount;
                    spendDays = 0; // Reset consecutive spend days
                }
                else if (action == "spend")
                {
                    availableMoney -= amount;
                    spendDays++;
                }

                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }

                days++;
            }

            if (spendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else if (availableMoney >= tripCost)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}