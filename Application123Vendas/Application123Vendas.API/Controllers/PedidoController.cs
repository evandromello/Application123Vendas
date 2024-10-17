using Application123Vendas.Domain.Models;
using Application123Vendas.Service.Dto;
using Application123Vendas.Service.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Application123Vendas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoService _pedidoService;

        public PedidoController(ILogger<PedidoController> logger, IPedidoService pedidoService)
        {
            _logger = logger;
            _pedidoService = pedidoService;
        }

        /// <summary>
        /// Método destinado a retornar um pedido pelo numero da Venda.
        /// </summary>
        /// <param name="id">Numero da Venda</param>
        /// <returns>Retorna um objeto com informações da venda.</returns>
        [HttpGet("ObterPedido/{id}", Name = "ObterPedidoPorNumeroVenda")]
        public MessageReturn<PedidoDto> Get(int id)
        {
            try
            {
                var retorno = _pedidoService.ObterPedido(id);
                return new MessageReturn<PedidoDto>("Pedido criado com sucesso.", retorno);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return new MessageReturn<PedidoDto>(ex.Message, new PedidoDto());
            }
        }

        /// <summary>
        /// Método destinado a retornar os pedidos.
        /// </summary>
        /// <returns> Retornar uma lista de pedidos. </returns>
        [HttpGet("ObterPedidos", Name = "ObterPedidos")]
        public IEnumerable<PedidoDto> Get()
        {
            return _pedidoService.ObterPedidos();
        }

        /// <summary>
        /// Método destinado a inserir um novo pedido.
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns> Retorna o objeto inserido. </returns>
        [HttpPost("InserirPedido", Name = "InserirPedido")]
        public MessageReturn<PedidoDto> Post([FromBody] PedidoDto pedido)
        {
            try
            {
                var retorno = _pedidoService.InserirPedido(pedido);
                return new MessageReturn<PedidoDto>("Pedido criado com sucesso.", retorno);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);

                return new MessageReturn<PedidoDto>(ex.Message, new PedidoDto());
            }            
        }
    }
}
