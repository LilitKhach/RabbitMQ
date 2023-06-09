namespace Aggregator.RabbitMQ.Consumer.Interfaces
{
    public interface IConsumerService
    {
        Task ReadMessages();
    }
}
