using ModuloOrientacaoAObjetos.ContentContext.Enums;

namespace ModuloOrientacaoAObjetos.ContentContext;
public class Course : Content
{
    //método constructor para inicializar os objetos
    public Course(string title, string url)
        : base(title, url)
    {
        Modules = new List<Module>();

    }

    //tag do curso
    public string Tag { get; set; }

    //lista de modulos
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }

}