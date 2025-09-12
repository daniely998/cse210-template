// exceeding requirement: I also asked the user how they feel that day before entry

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        string option = "";
        while (option != "5")
        {
            Console.WriteLine("Welcome to the Jounral Program.");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            // Write
            if (option == "1")
            {
                Console.WriteLine("How are you feeling today?");
                string mood = Console.ReadLine();

                PromptGenerator promptGen = new PromptGenerator();
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string dateText = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(dateText, mood, prompt, response);
                journal.AddEntry(entry);
            }
            // Display
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            // Load
            else if (option == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            // Save
            else if (option == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            // Quit
            else if (option == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye.");
            }
        }
        
    }
}