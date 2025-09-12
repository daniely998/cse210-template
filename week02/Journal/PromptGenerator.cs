public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Did I meet anyone interesting today? If yes, who were they?", "What was the best part of today?", "If I had one thing I could do over today, what would it be?", "What was the strongest emotion I felt today?", "Am I satisfy with how today went?"};

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int r = random.Next(_prompts.Count);
        return _prompts[r];
    }
}