using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Assignment assignment = new Assignment("Samuel Bennett", "multiplication");
        string assignmentSummary = assignment.GetSummary();
        Console.WriteLine(assignmentSummary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", 7, "8-19");
        string mathSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();

        Console.WriteLine(mathSummary);
        Console.WriteLine(homeworkList);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingSummary = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();

        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    }
}
