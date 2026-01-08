using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        number = SquareNumber(number);
        DisplayResult(number,name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber (int number)
    {
        return number * number;
    }
    static void DisplayResult (int number , string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}