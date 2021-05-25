using System;

void main()
{
    Console.Write("Guess my secret number: ");
    int userGuess = 0;
    while (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.Write("I need an integer! ");
    }
    int theNumber = 42;
    if (theNumber == userGuess)
    {
        Console.WriteLine("You got it right on the nose!");
    }
    else
    {
        Console.WriteLine("I win mwhahahahahhah!");
    }

}

main();