// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Welcome to the Math Game. Please enter your name");

string name = GetName();
var date = DateTime.UtcNow;

Menu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name, DateTime date)
{
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is a simple Math game.");
    Console.WriteLine("\n");
    Console.WriteLine($@"Please select one of the operations to start the game:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit Program");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}
void AdditionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int firstNum;
    int secondNum;
    var score = 0;

    for(int i = 0; i < 5; i++)
    {
        firstNum = random.Next(1, 9);
        secondNum = random.Next(1, 9);

        Console.WriteLine($"{firstNum} + {secondNum}");
        var sum = firstNum + secondNum;
        var userAnswer = Console.ReadLine();

        if (int.Parse(userAnswer) == sum)
        {
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int firstNum;
    int secondNum;
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNum = random.Next(1, 9);
        secondNum = random.Next(1, 9);

        Console.WriteLine($"{firstNum} - {secondNum}");
        var diff = firstNum + secondNum;
        var userAnswer = Console.ReadLine();

        if (int.Parse(userAnswer) == diff)
        {
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int firstNum;
    int secondNum;
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNum = random.Next(1, 9);
        secondNum = random.Next(1, 9);

        Console.WriteLine($"{firstNum} * {secondNum}");
        var prod = firstNum + secondNum;
        var userAnswer = Console.ReadLine();

        if (int.Parse(userAnswer) == prod)
        {
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNum = divisionNumbers[0];
        var secondNum = divisionNumbers[1];

        Console.WriteLine($"{firstNum} / {secondNum}");
        var quot = firstNum / secondNum;
        var userAnswer = Console.ReadLine();

        if (int.Parse(userAnswer) == quot)
        {
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0,99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

