namespace Libray.ContentContext;

public abstract class Content
{
    public Content(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; set; }
    public string Author { get; set; }
}