using ModuloOrientacaoAObjetos.ContentContext;
using ModuloOrientacaoAObjetos.ContentContext.Enums;

class Program
{
    static void Main(string[] args)
    {
        //instancia da lista de artigos
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre Csharp", "Csharp"));
        articles.Add(new Article("Artigo sobre DotNet", "DotNet"));


        foreach (var article in articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);

        }

        //instancia da lista de cursos
        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
        courses.Add(courseOOP);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);

        var careers = new List<Career>();
        var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
        var CareerItem3 = new CareerItem(3, "Comece por aqui", "", null);
        var CareerItem2 = new CareerItem(2, "Aula-02", "", null);
        var CareerItem1 = new CareerItem(1, "Aula-01", "", null);

        careerDotnet.Items.Add(CareerItem3);
        careerDotnet.Items.Add(CareerItem2);
        careerDotnet.Items.Add(CareerItem1);


        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);
            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
            }

        }

    }

}
