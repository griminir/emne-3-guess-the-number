// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Guess the number");

var random = new Random();

int rightNumber = random.Next(1, 101);
//bool rightGuess = false;
int count = 0;

while (!myGuess())
{
    myGuess();
    //count++;
}

//void myGuess()
//{
//    Console.WriteLine("Guess a number between 1 and 100?");
//    var imGuessing = Console.ReadLine();
//    int guessedNumber = 0; 
//    bool isaNumber = int.TryParse(imGuessing, out guessedNumber);

//    if (rightNumber == guessedNumber && isaNumber)
//    {
//        Console.WriteLine($"Correct you used {count + 1} guesses");
//        rightGuess = true;
//    } else if (rightNumber > guessedNumber && isaNumber)
//    {
//        Console.WriteLine("it's higher");
//    } else if (rightNumber < guessedNumber && isaNumber)
//    {
//        Console.WriteLine("it's lower");
//    } else
//    {
//        Console.WriteLine("please type a number");
//    }
//}

bool myGuess()
{
    string guess = "";
    int guessedNumber = 0;

    Console.WriteLine("Guess a number between 1 and 100?");
    do
    {
        Console.WriteLine("please type a number");
        guess = Console.ReadLine();
        count ++;
    } while (!int.TryParse(guess, out guessedNumber));
    

    if (rightNumber == guessedNumber)
    {
        Console.WriteLine($"Correct you used {count} guesses");
        return true;
    } else
    {
        Console.WriteLine((guessedNumber > rightNumber) ? "Your guess was too high" : "Your guess was too low");
        return false;
    }
}