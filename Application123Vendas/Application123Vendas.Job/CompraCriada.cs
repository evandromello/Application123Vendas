using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace Application123Vendas.Job
{
    public class CompraCriadaJob : IInvocable
    {
        private ILogger<CompraCriadaJob> _logger;

        public CompraCriadaJob(ILogger<CompraCriadaJob> logger)
        {
            _logger = logger;
        }

        public Task Invoke()
        {        
            // TODO Implementar Messageria para controlar o status das Vendas.
            return Task.CompletedTask;
        }
    }
}
