using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application123Vendas.Domain.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int? ClienteId { get; set; }

        [ForeignKey("Filial")]
        public int FilialId { get; set; }

        public DateTime DataVenda { get; set; }
        public DateTime DataRegistro { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public string Situacao { get; set; }
    }
}
