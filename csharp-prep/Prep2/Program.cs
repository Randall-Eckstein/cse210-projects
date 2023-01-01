using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage: ");
        string response = Console.ReadLine();
        float percent = float.Parse(response);

        string letter = "A";
        string sign = "";
        if (percent > 90)
        {
            letter = "an A";
        }
        else if (percent > 80)
        {
            letter = "a B";
        }
        else if (percent > 70)
        {
            letter = "a C";
        }
        else if (percent > 60)
        {
            letter = "a D";
        }
        else
        {
            letter = "an F";;
        }

        int scoreRemainder = (int)percent % 10;

        if (((90 - percent) * (percent - 60)) > 0 && scoreRemainder > 7)
        {
            sign = "+";
        }
        else if (((100 - percent) * (percent - 60)) > 0 && scoreRemainder < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"{response} is {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations!  You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, that is not enough to pass the class.  You'll do better next time.");
        }
    }
}