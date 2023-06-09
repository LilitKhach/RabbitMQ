using RabbitMQ.Client;

namespace Aggregator.RabbitMQ.Producer.Services
{
    public class RabbitMqService
    {
        public static IConnection CreateChannel()
        {
            ConnectionFactory connection = new()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            connection.DispatchConsumersAsync = true;
            var channel = connection.CreateConnection();
            return channel;
        }
    }
}
