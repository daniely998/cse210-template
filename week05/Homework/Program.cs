using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment ass = new WritingAssignment("Mary Waters", "Histroy", "The Causes of World War III");
        Console.WriteLine(ass.GetWritingInformation());
    }
}