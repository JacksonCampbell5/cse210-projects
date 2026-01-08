using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        if (grade < 70)
        {
            Console.WriteLine("You failed the class. Do better next time.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        if (grade < 60)
        {
            letter = "F" ;
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }
        Console.WriteLine($"Your final grade is {letter}");
    }
}