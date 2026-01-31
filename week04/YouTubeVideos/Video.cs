using System.Diagnostics.Contracts;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string DisplayTitle()
    {
        return _title;
    }
    public string DisplayAuthor()
    {
        return _author;
    }
    public int DisplayLength()
    {
        return _length;
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name,text);
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}