using Application123Vendas.Domain.Models;
using Application123Vendas.Repository.Data.Contracts;
using Application123Vendas.Service.Service.Contracts;
using AutoMapper;

namespace Application123Vendas.Service.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _pedidoRepository = pedidoRepository;
        }

        #region Métodos Públicos

        public PedidoDto ObterPedido(int id)
        {
            if (id == 0)
                throw new Exception("Informe o número correto da venda.");

            return _mapper.Map<PedidoDto>(_pedidoRepository.ObterPedido(id));
        }

        public IEnumerable<PedidoDto> ObterPedidos()
        {
            return _mapper.Map<IEnumerable<PedidoDto>>(_pedidoRepository.ObterPedidos());
        }

        public PedidoDto InserirPedido(PedidoDto pedidoDto)
        {
            ValidarPedido(pedidoDto);

            var pedido = _mapper.Map<Pedido>(pedidoDto);

            var resultPedidoDto = _mapper.Map<PedidoDto>(_pedidoRepository.InserirPedido(pedido));

            return resultPedidoDto;
        }

        #endregion

        #region Métodos privados

        private static void ValidarPedido(PedidoDto pedidoDto)
        {
            if (pedidoDto.Id > 0)
                throw new Exception("Para inserir um novo registro o Id não pode conter um valor.");

            int.TryParse(pedidoDto.Situacao.ToString(), out int situacao);
            if (situacao > 3)
                throw new Exception("A Situação deve ser 0 = Criado / 1 = EmAndamento / 2 = Finalizado / 3 = Cancelado.");
        }

        #endregion
    }
}
