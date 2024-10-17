using Application123Vendas.Repository.Data;
using Application123Vendas.Repository.Data.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Application123Vendas.IoC
{
    public static class RepositoryRegistration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepository, PedidoRepository>();
        }
    }
}
