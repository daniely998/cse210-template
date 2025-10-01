public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity() { }
    public void Set(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetLog()
    {
        return $"You completed a {_name} Activity for {_duration} seconds.";
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = ["+", "x"];
        int j = 0;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(animation[j]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            j++;

            if (j >= animation.Count)
            {
                j = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}