using ModuloOrientacaoAObjetos.ContentContext.Enums;

namespace ModuloOrientacaoAObjetos.ContentContext;

public class Lecture
{
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;

    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}

