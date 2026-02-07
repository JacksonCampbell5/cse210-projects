public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "breathing activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        Console.Clear();
        base.DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write("Breathe in... ");
            base.ShowCountDownSeconds(5);
            Console.WriteLine("");
            Console.Write("Now Breath out... ");
            base.ShowCountDownSeconds(5);
            Console.WriteLine("");
        }while (DateTime.Now < futureTime);
        base.DisplayEndingMessage();
    }

}