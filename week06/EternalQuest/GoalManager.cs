using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new();
        _score = 0;
    }
    public void Start()
    {
        string choice = "";
        while (choice != "7")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Events");
            Console.WriteLine("  6. Remove Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            // Create goal
            if (choice == "1")
            {
                CreateGoal();
            }
            // List goal
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            // Save goal
            else if (choice == "3")
            {
                SaveGoals();
            }
            // Load goal
            else if (choice == "4")
            {
                LoadGoals();
            }
            // Record event
            else if (choice == "5")
            {
                RecordEvent();
            }
            // Remove goal
            else if (choice == "6")
            {
                RemoveGoal();
            }
            // Quit
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailString()}");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int point = int.Parse(Console.ReadLine());
        // simple
        if (type == "1")
        {
            SimpleGoal goal = new(name, description, point);
            _goals.Add(goal);
        }
        // eternal
        else if (type == "2")
        {
            EternalGoal goal = new(name, description, point);
            _goals.Add(goal);
        }
        // checklist
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new(name, description, point, target, bonus);
            _goals.Add(goal);
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;
        _goals[i].RecordEvent();
        _score += _goals[i].GetPoint();
        System.Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        using (StreamWriter output = new(file))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (line == lines[0])
            {
                _score = int.Parse(line);
            }
            else
            {
                string[] types = line.Split(":");
                foreach (string type in types)
                {
                    if (type != types[0])
                    {
                        string[] parts = type.Split("/");
                        string name = parts[0];
                        string description = parts[1];
                        int point = int.Parse(parts[2]);
                        if (types[0] == "SimpleGoal")
                        {
                            SimpleGoal goal = new(name, description, point);
                            _goals.Add(goal);
                        }
                        else if (types[0] == "EternalGoal")
                        {
                            EternalGoal goal = new(name, description, point);
                            _goals.Add(goal);
                        }
                        else if (types[0] == "ChecklistGoal")
                        {
                            int bonus = int.Parse(parts[3]);
                            int target = int.Parse(parts[4]);
                            int completed = int.Parse(parts[5]);
                            ChecklistGoal goal = new(name, description, point, target, bonus);
                            goal.SetCompleted(completed);
                            _goals.Add(goal);
                        }
                    }
                }
            }
        }
    }
    public void RemoveGoal()
    {
        ListGoalDetails();
        Console.Write("Which Goal do you want to remove? ");
        int remove = int.Parse(Console.ReadLine()) - 1;
        _goals.RemoveAt(remove);
    }
}