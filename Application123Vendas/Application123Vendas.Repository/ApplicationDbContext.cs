using Application123Vendas.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application123Vendas.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<PedidoProduto> PedidoProduto { get; set; }
    }
}
