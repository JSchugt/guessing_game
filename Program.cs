using System;
int numberValidator(int userGuess)
{
    while (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.Write("I need an integer! ");
    }
    return userGuess;
}
void main()
{
    int counter = 1;
    Console.Write($"You have 4 guesses \n Guess my secret number ({counter}): ");
    Random gen = new Random();

    int userGuess = 0;
    int theNumber = gen.Next(1, 100);
    userGuess = numberValidator(userGuess);
    bool correctGuess = false;
    while (counter < 4 && !correctGuess)
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
            Console.WriteLine($"You have {5 - counter} guesses left!");
            Console.Write($"Guess again({counter}): ");
            userGuess = numberValidator(userGuess);
        }
    }
    Console.WriteLine(theNumber);
}

main();