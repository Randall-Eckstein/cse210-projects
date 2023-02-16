using System;
namespace Learning04;

class Program
{
    static void Main(string[] args)
    {
       MathAssignment math1 = new MathAssignment("Geometry", "6-12", "Samantha", "Mathematics");

       WritingAssignment writing1 = new WritingAssignment("Diana", "Essays on World History", "Prevention of World War Two");

       Console.WriteLine(math1.GetSummary());
       Console.WriteLine(math1.GetHomeworkList());

       Console.WriteLine(writing1.GetSummary());
       Console.WriteLine(writing1.GetWritingInformation());
       
    }
}