using System;
int numberValidator(int userGuess)
{
    while (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.Write("I need an integer! ");
    }
    return userGuess;
}
int difficultyValidator(int userGuess)
{
    while (!int.TryParse(Console.ReadLine(), out userGuess) && userGuess < 1 && userGuess > 3)
    {
        Console.Write("I need an integer! between 1 and 3: ");
    }
    if (userGuess == 1)
    {
        userGuess = 8;
    }
    else if (userGuess == 2)
    {
        userGuess = 6;
    }
    else if (userGuess == 3)
    {
        userGuess = 4;
    }
    else
    {
        userGuess = 1000000;
    }
    return userGuess;
}
void main()
{
    Console.WriteLine("What difficulty would you like \n 1. Easy \n 2. Medium \n 3. Hard \n 4. Cheater");
    int difficulty = difficultyValidator(0);
    int counter = 1;
    string diff = difficulty > 4 ? "unlimited" : difficulty.ToString();
    Console.Write($"You have {diff} guesses \n Guess my secret number ({counter}): ");
    Random gen = new Random();

    int userGuess = 0;
    int theNumber = gen.Next(1, 100);
    userGuess = numberValidator(userGuess);
    bool correctGuess = false;
    while (counter < difficulty && !correctGuess)
    {
        counter++;
        if (theNumber == userGuess)
        {
            Console.WriteLine("You got it right on the nose!");
            correctGuess = true;
        }
        else if (difficulty > 4)
        {
            string range = (userGuess > theNumber) ? "Your guess was too high" : "Your guess was too low";
            Console.WriteLine(range);
            Console.Write($"Guess again({counter}): ");
            userGuess = numberValidator(userGuess);
        }
        else
        {
            string range = (userGuess > theNumber) ? "Your guess was too high" : "Your guess was too low";
            Console.WriteLine(range);
            Console.WriteLine($"You have {difficulty - counter + 1 } guesses left!");
            Console.Write($"Guess again({counter}): ");
            userGuess = numberValidator(userGuess);
        }
    }
    Console.WriteLine(theNumber);
}

main();