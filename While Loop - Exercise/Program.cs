namespace While_Loop___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string takenBook = Console.ReadLine();
            int countChechedBooks = 0;

            while (takenBook != "No More Books")
            {
                if (takenBook == searchedBook)
                {
                    Console.WriteLine($"You checked {countChechedBooks} books and found it.");
                    return;
                }
                else
                {
                    countChechedBooks++;
                }

                takenBook = Console.ReadLine();
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {countChechedBooks} books.");
        }
    }
}