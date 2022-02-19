using Casa_Do_Suplemento.Models;
using Microsoft.EntityFrameworkCore;

namespace Casa_Do_Suplemento.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)   
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Suplemento> Suplementos { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    }
}
