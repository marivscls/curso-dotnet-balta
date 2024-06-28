using System.ComponentModel.DataAnnotations;

namespace Library.Models;



public class ClientesEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

}


public class LivrosEntity
{
    [Key]
    public int Id_Livro { get; set; }
    public string Título { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public int Preço { get; set; }
    public int? Estoque { get; set; }
}


public class PedidosEntity
{
    [Key]
    public int Id_Pedido { get; set; }
    public int? Id_Cliente { get; set; }
    public int? Id_Livro { get; set; }
    public DateTime? Data_Pedido { get; set; }
    public int? Quantidade { get; set; }

}