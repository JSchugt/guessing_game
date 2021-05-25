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
    else
    {
        userGuess = 4;
    }
    return userGuess;
}
void main()
{
    Console.WriteLine("What difficulty would you like \n 1. Easy \n 2. Medium \n 3. Hard");
    int difficulty = difficultyValidator(0);
    int counter = 1;
    Console.Write($"You have {difficulty} guesses \n Guess my secret number ({counter}): ");
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