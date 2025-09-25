public class Video
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
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }
    public int GetCommentNum()
    {
        return _comments.Count;
    }
    public string Display()
    {
        string display = $"Video Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments: {GetCommentNum()}\n";
        foreach (Comment comment in _comments)
        {
            display += $"{comment.Display()}\n";
        }
        return display;
    }
}