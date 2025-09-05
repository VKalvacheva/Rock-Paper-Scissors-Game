using System;

class Program
{
    static void Main()
    {
        string[] options = { "rock", "paper", "scissors" };
        Random random = new Random();

        Console.WriteLine("Welcome to Rock-Paper-Scissors!");
        Console.WriteLine("Type 'rock', 'paper', or 'scissors' to play. Type 'exit' to quit.");

        while (true)
        {
            Console.Write("Your choice: ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "exit")
                break;

            if (Array.IndexOf(options, userChoice) == -1)
            {
                Console.WriteLine("Invalid choice. Try again.");
                continue;
            }

            string computerChoice = options[random.Next(0, 3)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper")
            )
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
