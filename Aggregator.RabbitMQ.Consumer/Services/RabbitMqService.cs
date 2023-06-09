using RabbitMQ.Client;

namespace Aggregator.RabbitMQ.Consumer.Services
{
    public class RabbitMqService
    {
        public static IConnection CreateChannel()
        {
            ConnectionFactory connection = new ConnectionFactory()
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
