using Aggregator.RabbitMQ.Consumer.Interfaces;

namespace Aggregator.RabbitMQ.Consumer.HostedServices
{
    public class ConsumerHostedService : BackgroundService
    {
        private IConsumerService _consumerService;

        public ConsumerHostedService(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _consumerService.ReadMessages();
        }
    }
}
