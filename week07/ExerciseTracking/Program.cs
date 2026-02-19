using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");
        Console.Clear();
        Running run = new Running(date , 30 , 4.8);
        Cycling bike = new Cycling(date , 30 , 60);
        Swimming swim = new Swimming(date , 0.5 , 1);
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}