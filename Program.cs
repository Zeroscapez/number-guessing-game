int randomNum = Random.Shared.Next(1, 101);

int guess = 0;
int totalGuesses = 0;
int maxGuesses = 7;
int currentGuesses;
string? playing = null;

Console.WriteLine($"You have {maxGuesses} guesses.");
currentGuesses = maxGuesses;
int bestScore = 7;
do
{

    Console.Write("Guess a number from 1 to 100: ");
    if (!int.TryParse(Console.ReadLine(), out int guessValue) || guessValue < 1)
    {
        Console.WriteLine("Input must be a number between 1 and 100.");
    }
    else
    {
        guess = guessValue;
        currentGuesses--;


        if (guess > randomNum)
        {
            Console.WriteLine("Too High.");
            totalGuesses++;
        }

        if (guess < randomNum)
        {
            Console.WriteLine("Too Low.");
            totalGuesses++;
        }

        Console.WriteLine($"Guesses Left: {currentGuesses}");
    }

    if ((guess == randomNum) || (currentGuesses <= 0))
    {
        if (guess == randomNum)
        {
            totalGuesses++;
            Console.WriteLine($"It took you, {totalGuesses} guesses.");

        }

        if (currentGuesses <= 0 && guess != randomNum)
        {
            Console.WriteLine($"You lose, the number was {randomNum}");

        }

        if (totalGuesses < bestScore)
        {
            bestScore = totalGuesses;
        }

        do
        {
            Console.Write("Play Again? (Y/N): ");
            playing = Console.ReadLine();
            if (playing == "Y")
            {

                currentGuesses = maxGuesses;
                totalGuesses = 0;
                randomNum = Random.Shared.Next(1, 101);
                Console.WriteLine($"Debug Only: {randomNum}");
                break;
            }

        } while (playing != "N");

    }




} while (playing != "N");


Console.WriteLine($"Your least amount of guesses was: {bestScore}");