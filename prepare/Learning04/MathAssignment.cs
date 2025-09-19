public class MathAssignment : Assignment
{

    private string homeworkList;

    public MathAssignment(string studentName, String topic, int section, string problems) : base(studentName, topic)
    {
        this.homeworkList = $"Section {section} Problems {problems}";

    }


    public string GetHomeworkList()
    {
        return homeworkList;
    }


}