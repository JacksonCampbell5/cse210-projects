using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        string choice = "";
        do
        {
            Console.WriteLine(@"Welcome to the Journal Programme!
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit"
            );
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();
            choice = choice.ToLower();
            if (choice == "1" || choice == "write")
            {
                Write(newJournal);
            }
            if (choice == "2" || choice == "display")
            {
                newJournal.DisplayAll();
            }
            if (choice == "3" || choice == "load")
            {
                Load(newJournal);
            }
            if (choice == "4" || choice == "save")
            {
                Save(newJournal);
            }
        } while (!(choice == "5" || choice == "quit"));
    }

    static void Write(Journal newJournal)
    {
        Entry newEntry = new Entry();
        newEntry._prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._message = Console.ReadLine();
        DateTime currentTime = DateTime.Now;
        newEntry._date = $"{currentTime.ToShortDateString()} {currentTime.ToShortTimeString()}";
        newJournal.AddEntry(newEntry);
        Console.WriteLine();
    }

    static void Load(Journal newJournal)
    {
        Console.Write("Enter file name: ");
        newJournal.LoadFromFile(Console.ReadLine());
    }

    static void Save(Journal newJournal)
    {
        Console.Write("Enter file name: ");
        newJournal.SaveToFile(Console.ReadLine());
    }
}