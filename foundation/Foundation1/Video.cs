using System;
using System.Collections.Generic;

public class Video
{
    private string _author;
    private string _title;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public void SetVideoMeta(params object[] args)
    {
        if (args.Length < 3)
        {
            throw new ArgumentException("Insufficient arguments provided.");
        }

        _author = args[0].ToString();
        _title = args[1].ToString();
        _videoLength = int.Parse(args[2].ToString());
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentatorName()} - {comment.GetTheComment()}");
        }

        Console.WriteLine("");
    }

    public void DisplayMetaData()
    {
        string meta = $"Author of Video: {GetAuthor()}\nTitle: {GetTitle()}\nVideo Length: {GetVideoLength()} min(s)";
        Console.WriteLine(meta);
    }
}
