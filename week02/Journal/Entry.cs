public class Entry
{
    public string _date;
    public string _mood;
    public string _promptText;
    public string _entryText;

    public Entry(string date = "", string mood = "", string prompt = "", string entry = "")
    {
        _date = date;
        _mood = mood;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_mood} - Prompt: {_promptText}\n{_entryText}");
    }
}