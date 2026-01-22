// Alowed the user to input their own scripture reference and text
// Only selects to hide words that are not already hidden
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input book: ");
        string book = Console.ReadLine();
        Console.Write("Input chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Input starting verse: ");
        string startVerse = Console.ReadLine();
        Console.Write("Input ending verse (leave blank if only one verse): ");
        string endVerse = Console.ReadLine();
        Reference reference = new Reference( book,int.Parse(chapter),int.Parse(startVerse));
        if (endVerse != "")
        {
            reference = new Reference( book,int.Parse(chapter),int.Parse(startVerse),int.Parse(endVerse));
        }
        Console.Write("Input scripture text: ");
        string text = Console.ReadLine();
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