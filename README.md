# Assignment 3

A C# Console app that has you play a number guessing game, you are given 7 guesses and must find the answer.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## How to run

```bash
git clone https://github.com/Zeroscapez/Old-Assignment-3.git
cd Assignment3
dotnet run
```

## Sample Output

```text
You have 7 guesses!
Guess a number from 1 to 100: 2
Too Low.
Guesses Left: 6
Guess a number from 1 to 100: 4
Correct! It took you 2 guess(es).
Play again? (Y/N): Y
You have 7 guesses!
Guess a number from 1 to 100: 9
Too Low.
Guesses Left: 6
Guess a number from 1 to 100: 19
Too Low.
Guesses Left: 5
Guess a number from 1 to 100: 40
Too Low.
Guesses Left: 4
Guess a number from 1 to 100: 80
Too High.
Guesses Left: 3
Guess a number from 1 to 100: 70
Too Low.
Guesses Left: 2
Guess a number from 1 to 100: 20
Too Low.
Guesses Left: 1
Guess a number from 1 to 100: 30
Too Low.
Guesses Left: 0
You lose, the number was 75
Play again? (Y/N): N
Your least amount of guesses was: 2
```