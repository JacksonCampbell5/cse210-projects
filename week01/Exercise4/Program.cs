using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int sum = 0;
        double average = 0;
        int largestNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            int newNumber = int.Parse(userInput);
                if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (userInput != "0");
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        average = (double)sum / numbers.Count;
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}