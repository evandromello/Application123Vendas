using Application123Vendas.Domain.Models;
using Application123Vendas.Repository.Data.Contracts;
using Application123Vendas.Service.Enums;
using Application123Vendas.Service.Service;
using AutoMapper;
using Moq;

namespace Application123Vendas.Test
{
    public class PedidoServiceUnitTest
    {
        private PedidoService pedidoService;

        public PedidoServiceUnitTest()
        {
            pedidoService = new PedidoService(new Mock<IPedidoRepository>().Object, new Mock<IMapper>().Object);
        }

        [Fact]
        public void Get_ObterPedidoPorNumeroVenda_Test()
        {
            var exception = Assert.Throws<Exception>(() => pedidoService.ObterPedido(0));
            Assert.Equal("Informe o número correto da venda.", exception.Message);
        }

        [Fact]
        public void Post_CriarNovoPedido_ValidaPedidoId_Test()
        {
            var exception = Assert.Throws<Exception>(() => pedidoService.InserirPedido(new PedidoDto { Id = 1 }) );
            Assert.Equal("Para inserir um novo registro o Id não pode conter um valor.", exception.Message);
        }

        [Fact]
        public void Post_CriarNovoPedido_ValidaStatusPedido_Test()
        {
            var exception = Assert.Throws<Exception>(() => pedidoService.InserirPedido(new PedidoDto { Situacao = (StatusPedido)4 }));
            Assert.Equal("A Situação deve ser 0 = Criado / 1 = EmAndamento / 2 = Finalizado / 3 = Cancelado.", exception.Message);
        }
    }
}