using Application123Vendas.Domain.Models;
using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PedidoDto, Pedido>();
        CreateMap<Pedido, PedidoDto>();
    }
}