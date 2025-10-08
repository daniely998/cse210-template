public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
    }
    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetStringRepresentation()}/{_isComplete}";
    }
}