using Application123Vendas.Domain.Models;

namespace Application123Vendas.Service.Service.Contracts
{
    public interface IPedidoService
    {
        PedidoDto ObterPedido(int id);
        IEnumerable<PedidoDto> ObterPedidos();
        PedidoDto InserirPedido(PedidoDto pedido);
    }
}
