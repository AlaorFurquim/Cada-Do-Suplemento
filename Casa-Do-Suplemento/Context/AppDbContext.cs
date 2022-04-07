using Casa_Do_Suplemento.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casa_Do_Suplemento.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)   
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Suplemento> Suplementos { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
