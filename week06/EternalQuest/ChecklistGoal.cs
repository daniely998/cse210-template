public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public void SetCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            IsComplete();
            SetPoint(_bonus);
        }
        Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailString()
    {
        return $"{base.GetDetailString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetStringRepresentation()}/{_bonus}/{_target}/{_amountCompleted}";
    }
}