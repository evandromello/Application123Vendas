using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application123Vendas.Domain.Models
{
    public class PedidoProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
