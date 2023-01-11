using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> entries = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float number = float.MinValue;
        while (number != 0)
        {
            bool canContinue = false;
            while (!canContinue)
            try
            {
                Console.Write("Enter a number: ");
                number = float.Parse(Console.ReadLine());
                if (number != 0)
                {
                    entries.Add(number);
                }
                canContinue = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, that is not a valid entry.  Please try again.");
            }
        }

        Console.WriteLine("\nCalculating your entries...");
        float sum = 0;
        float largest = float.MinValue;
        float smallestPositive = float.MaxValue;
        foreach (float item in entries)
        {
            sum += item;
            if (item > largest)
            {
                largest = item;
            }
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }
        float average = sum/ entries.Count();
        Console.WriteLine($"{sum} divided by {entries.Count()} is equal to {average}");
        Console.WriteLine($"The sum is {MathF.Round(sum, 2)}");
        Console.WriteLine($"The average is {MathF.Round(average, 2)}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {smallestPositive}");
        entries.Sort();
        Console.WriteLine("The sorted list of entries is as follows:");
        foreach (float item in entries)
        {
            Console.WriteLine($"\t{item}");
        }
    }
}