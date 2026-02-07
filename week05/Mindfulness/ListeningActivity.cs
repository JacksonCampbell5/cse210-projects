public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListeningActivity()
    {
        _name = "Listening Activity";
        _description = "This activiy will help you reflect ont he good things in your life by having you list as many things as you can in a certain area.";
    }
    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(0,_prompts.Count)]);
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        do
        {
            string text = Console.ReadLine();
            userList.Add(text);
        }while (DateTime.Now < futureTime);
        _count = userList.Count;
        return userList; 
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("List as may responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may beging in: ");
        base.ShowCountDownSeconds(5);
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        base.DisplayEndingMessage();
    }
}