namespace Libray.ContentContext;

public class Book : Content
{
    public Book(string title, string author)
        : base(title, author)
    {
        bookItems = new List<BookItem>();
    }

    public IList<BookItem> bookItems { get; set; }
    public int TotalBooks => bookItems.Count;

}