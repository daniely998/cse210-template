// Creativity: I added an option to review activities performed within the same program run
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _log = new List<Activity>();
        string option = "";
        while (option != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Review activities performed");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            // Breathing
            if (option == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                _log.Add(activity);
            }
            // Reflecting
            if (option == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                _log.Add(activity);
            }
            // Listing
            if (option == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                _log.Add(activity);
            }
            // Log
            if (option == "4")
            {
                Console.WriteLine("Here is a review of the activities you performed:");
                int i = 1;
                foreach (Activity activity in _log)
                {
                    Console.WriteLine($"  {i}. {activity.GetLog()}");
                    i++;
                }
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            //
            if (option == "5")
            {
                Console.WriteLine("Goodbye! Have a wonderful day.");
            }
        }
    }
}