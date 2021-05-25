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
    Console.Write("Guess my secret number: ");
    int counter = 1;
    int userGuess = 0;
    int theNumber = 42;
    userGuess = numberValidator(userGuess);
    bool correctGuess = false;
    while (counter < 4 && !correctGuess)
    {
        if (theNumber == userGuess)
        {
            Console.WriteLine("You got it right on the nose!");
            correctGuess = true;
        }
        else
        {
            Console.Write("Guess again: ");
            userGuess = numberValidator(userGuess);
        }
        counter++;
    }


}

main();