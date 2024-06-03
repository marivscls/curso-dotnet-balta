
namespace ModuloOrientacaoAObjetos.ContentContext;

public class Module
{
    //constructor para inicializar os objetos
    public Module()
    {
        Lectures = new List<Lecture>();
    }
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

}

