// Added an option for the user to input their own scripture reference and text
// Only selects to hide words that are not already hidden
using System;

class Program
{
    static void Main(string[] args)
    {
        string option;
        string book;
        string chapter;
        string startVerse;
        string endVerse;
        string text; 
        do
        {
            Console.Write("Would you like to input your own verse? (yes/no): ");
            option = Console.ReadLine().ToLower();
        } while (option != "yes" && option != "no");

        if (option == "yes")
        {
            Console.Write("Input book: ");
            book = Console.ReadLine();
            Console.Write("Input chapter: ");
            chapter = Console.ReadLine();
            Console.Write("Input starting verse: ");
            startVerse = Console.ReadLine();
            Console.Write("Input ending verse (leave blank if only one verse): ");
            endVerse = Console.ReadLine();
            Console.Write("Input scripture text: ");
            text = Console.ReadLine();
;
        }
        else
        {
            book = "Proverbs";
            chapter = "3";
            startVerse = "5";
            endVerse = "6";
            text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }

        Reference reference = new Reference( book,int.Parse(chapter),int.Parse(startVerse));
        if (endVerse != "")
        {
            reference = new Reference( book,int.Parse(chapter),int.Parse(startVerse),int.Parse(endVerse));
        }
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:" );
        string responce = Console.ReadLine().ToLower();
        do
        {
            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:" );
            responce = Console.ReadLine().ToLower();
            
        } while (responce != "quit" && !scripture.IsCompletleyHidden());
    }
}