public class Resume
{
    public string _name ;
    public List<Job> _Jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _Jobs)
        {
            job.Display();
        }
    }
}