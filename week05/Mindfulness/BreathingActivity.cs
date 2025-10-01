public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        string name = "Breathing";
        string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
        Set(name, description);
    }
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        if (duration <= 8)
        {
            Excercise(4);
        }
        else
        {
            if (duration % 8 != 0)
            {
                Excercise(2);
            }
            int lap = duration / 8;
            for (int i = 0; i < lap; i++)
            {
                Excercise(4);
            }
        }

        DisplayEndingMessage();
    }
    private void Excercise(int seconds)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(seconds);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountDown(seconds);
    }
}