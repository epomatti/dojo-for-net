using System;
using RabbitMQ.Client;
using System.Text;

class Messaging
{
    public void Enqueue(String message, String queue)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: queue,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: "",
                                 basicProperties: null,
                                 body: body);
        }
    }
}