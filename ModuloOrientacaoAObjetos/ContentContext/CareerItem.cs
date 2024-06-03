namespace ModuloOrientacaoAObjetos.ContentContext;

public class CareerItem
{
    public CareerItem(int order, string title, string description, Course course)
    {
        Order = order;
        Title = title;
        this.description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string description { get; set; }
    public Course Course { get; set; }

}

