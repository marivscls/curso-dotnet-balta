using Libray.SharedContext;

namespace Libray.ContentContext;


public class BookItem : Base
{
    public BookItem(int order, string title, string description, string synopsis)
    {
        Order = order;
        Title = title;
        Description = description;
        Synopsis = synopsis;
    }


    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Synopsis { get; set; }

}