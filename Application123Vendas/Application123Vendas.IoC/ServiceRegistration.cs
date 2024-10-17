using Application123Vendas.Service.Service;
using Application123Vendas.Service.Service.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Application123Vendas.IoC
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();
        }
    }
}
