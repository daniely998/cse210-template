public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public int GetPoint()
    {
        return _points;
    }
    public void SetPoint(int point)
    {
        _points = point;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        char check = ' ';
        if (IsComplete())
        {
            check = 'X';
        }
        return $"[{check}] {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}/{_description}/{_points}";
    }
}