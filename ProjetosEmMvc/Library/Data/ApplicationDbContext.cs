namespace Library.Data;
using Library.Models;


using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<ClientesEntity> Clientes { get; set; }
    public DbSet<LivrosEntity> Livros { get; set; }
    public DbSet<PedidosEntity> Pedidos { get; set; }
}