public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> Comments { get; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public IEnumerable<Comment> GetComments()
    {
        return Comments;
    }
}