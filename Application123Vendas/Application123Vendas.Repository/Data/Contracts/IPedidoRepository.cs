using Application123Vendas.Domain.Models;

namespace Application123Vendas.Repository.Data.Contracts
{
    public interface IPedidoRepository
    {
        Pedido ObterPedido(int id);
        IEnumerable<Pedido> ObterPedidos();
        Pedido InserirPedido(Pedido pedido);
    }
}
