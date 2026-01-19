public class PromptGenerator
{
    public static List<string> _promptList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today what would it be?"
    };
    public static string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _promptList[rnd.Next(0,PromptGenerator._promptList.Count)];
    }

}