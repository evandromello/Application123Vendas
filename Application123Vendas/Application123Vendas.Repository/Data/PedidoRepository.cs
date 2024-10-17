using Application123Vendas.Domain.Models;
using Application123Vendas.Repository.Data.Contracts;
using Microsoft.Extensions.Configuration;

namespace Application123Vendas.Repository.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        ApplicationDbContext _applicationDbContext;
        IConfiguration _configuration;

        public PedidoRepository(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            _applicationDbContext = applicationDbContext;
            _configuration = configuration;
        }
        public Pedido ObterPedido(int id)
        {
            return _applicationDbContext.Pedido.Where(x=> x.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<Pedido> ObterPedidos()
        {
            return _applicationDbContext.Pedido;
        }

        public Pedido InserirPedido(Pedido pedido)
        {
            var entidade = _applicationDbContext.Add(pedido);
            _applicationDbContext.SaveChanges();
            return entidade.Entity;
        }
    }
}
