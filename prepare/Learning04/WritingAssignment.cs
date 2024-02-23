using System;

public class WritingAssignment : Assignment
{
    private string writingTitle;

    public WritingAssignment(string studentName, string topic, string writingTitle)
        : base(studentName, topic)
    {
        this.writingTitle = writingTitle;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {base.GetTopic()}\n{writingTitle} by {GetStudentName()}";
    }
}
