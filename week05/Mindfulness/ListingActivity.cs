public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        string name = "Listing";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Set(name, description);
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int r = random.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[r]} ---");
    }
    public List<string> GetListFromUser()
    {
        List<string> _list = new List<string>();
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("< ");
            string response = Console.ReadLine();
            _list.Add(response);
            _count++;
        }
        return _list;
    }
}