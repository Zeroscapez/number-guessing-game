int? bestScore = null;
const int MaxGuesses = 7;
while (true)
{
    int randomNum = Random.Shared.Next(1, 101);
    int guessesUsed = 0;
    bool won = false;
    Console.WriteLine($"You have {MaxGuesses} guesses!");
    while (guessesUsed < MaxGuesses && !won)
    {
        Console.Write("Guess a number from 1 to 100: ");
        if (!int.TryParse(Console.ReadLine(), out int guessValue) || guessValue < 1 || guessValue > 100)
        {
            Console.WriteLine("Input must be a number between 1 and 100.");
        }
        else
        {
            guessesUsed++;
            if (guessValue > randomNum)
            {
                Console.WriteLine("Too High.");
            }
            else if (guessValue < randomNum)
            {
                Console.WriteLine("Too Low.");


            }
            else
            {
                won = true;
            }

        }
        if (!won)
        {
            Console.WriteLine($"Guesses Left: {MaxGuesses - guessesUsed}");
        }

    }

    if (won)
    {
        Console.WriteLine($"Correct! It took you {guessesUsed} guess(es).");
        if (bestScore == null || guessesUsed < bestScore)
        {
            bestScore = guessesUsed;
        }

    }
    else
    {
        Console.WriteLine($"You lose, the number was {randomNum}");
    }


    Console.Write("Play again? (Y/N): ");
    string? response = Console.ReadLine();

    if (response?.Trim().ToLower() != "y")
    {
        break;
    }


}

if (bestScore == null)
{
    Console.WriteLine("You didn't win any rounds");
}
else
{
    Console.WriteLine($"Your least amount of guesses was: {bestScore}");
}


