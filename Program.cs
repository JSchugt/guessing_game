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
    Console.Write($"Guess my secret number ({counter}): ");
    int userGuess = 0;
    int theNumber = 42;
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
            Console.Write($"Guess again({counter}): ");
            userGuess = numberValidator(userGuess);
        }
    }


}

main();