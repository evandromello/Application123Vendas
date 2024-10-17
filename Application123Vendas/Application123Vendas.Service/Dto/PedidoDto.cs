using Application123Vendas.Service.Enums;

namespace Application123Vendas.Domain.Models
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int FilialId { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataRegistro { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Situacao { get; set; }
    }
}
