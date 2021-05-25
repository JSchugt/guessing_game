using System;

void main()
{
    Console.Write("Guess my secret number: ");
    int userGuess = 0;
    while (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.Write("I need an integer! ");
    }
    Console.WriteLine($"You guessed {userGuess}");
}

main();