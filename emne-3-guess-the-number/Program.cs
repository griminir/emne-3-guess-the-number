// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Guess the number");

Random random = new Random();

int rightNumber = random.Next(1, 101);
bool rightGuess = false;
int count = 0;

while (!rightGuess)
{
    myGuess();
    count++;
}

void myGuess()
{
    Console.WriteLine("Guess a number between 1 and 100?");
    var imGuessing = Console.ReadLine();
    int guessedNumber = 0; 
    bool isaNumber = int.TryParse(imGuessing, out guessedNumber);

    if (rightNumber == guessedNumber && isaNumber)
    {
        Console.WriteLine($"Correct you used {count + 1} guesses");
        rightGuess = true;
    } else if (rightNumber > guessedNumber && isaNumber)
    {
        Console.WriteLine("it's higher");
    } else if (rightNumber < guessedNumber && isaNumber)
    {
        Console.WriteLine("it's lower");
    } else
    {
        Console.WriteLine("please type a number");
    }
}