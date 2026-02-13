using System.Threading.Channels;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    int _score = 0;
    public GoalManager(){
        
    }
    public void Start()
    {
        string menu = "";
        do
        {
            Console.WriteLine(@$"
You have {_score} points.

Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Delete Goal
    7. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                CreateGoal();
            }
            else if (menu == "2")
            {
                ListGoalDetails();
            }
            else if (menu == "3")
            {
                SaveGoals();
            }
            else if (menu == "4")
            {
                LoadGoals();
            }
            else if (menu == "5")
            {
                RecordEvent();
            }
            else if (menu == "6")
            {
                DeleteGoal();
            }
        } while(menu != "7");
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] parts = _goals[i].GetStringRepresentation().Split("`");
            Console.WriteLine($"{i + 1}. {parts[1]}");
        }
    }
    public void ListGoalDetails()
    {
        for( int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine(@$"
The types of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");  
        string menu = Console.ReadLine();
        Console.Write("What is tha name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the ammount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (menu == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
            _goals.Add(simpleGoal);
        }
        else if (menu == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        else if (menu == "3")
        {
            Console.Write("How many times does it need to be achomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string menu = Console.ReadLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            if ((i + 1).ToString() == menu)
            {
                _goals[i].RecordEvent();
                _score += _goals[i].GetPoints();
                Console.WriteLine($"You now have {_score} points!");
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goals? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("`");
            if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
                simpleGoal.SetIsComplete(bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus);
                checklistGoal.SetAmmountCompleted(int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
    public void DeleteGoal()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal would you like to remove? (any points earned will be kept) ");
        string menu = Console.ReadLine();
        for (int i = 0; i < _goals.Count; i++)
        {
            if ((i + 1).ToString() == menu)
            {
                _goals.RemoveAt(i);
            }
        }
    }
}