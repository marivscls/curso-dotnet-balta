using Libray.ContentContext;

class Program
{
    static void Main(string[] args)
    {
        var book = new List<BookItem>();
        book.Add(new BookItem(1, "e assim que termina", "sadsdfsdf", "asdasdasd"));

        foreach (var item in book)
        {
            Console.WriteLine(item.Title);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Order);
            Console.WriteLine(item.Synopsis);

        }


        var books = new List<Book>();

        books.Count();

        foreach (var item in books)
        {
            Console.WriteLine(item.TotalBooks);
        }
    }
}