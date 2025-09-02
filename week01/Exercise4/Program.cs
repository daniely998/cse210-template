using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int x in numbers)
        {
            sum += x;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = 0;
        foreach (int x in numbers)
        {
            if (x > largest)
            {
                largest = x;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}