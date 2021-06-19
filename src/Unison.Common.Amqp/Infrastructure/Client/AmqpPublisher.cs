using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;
using Unison.Common.Amqp.DTO;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp.Infrastructure.Client
{
    public class AmqpPublisher : IAmqpPublisher
    {
        private readonly IAmqpManagedChannel _channel;

        public AmqpPublisher(IAmqpChannelFactory channelFactory)
        {
            _channel = channelFactory.CreateManagedChannel();
        }

        public void PublishMessage(AmqpMessage message, string exchange, string routingKey = null)
        {
            routingKey = routingKey ?? exchange;

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            _channel.GetChannel().BasicPublish(exchange: exchange,
                                               routingKey: routingKey,
                                               basicProperties: null,
                                               body: body);
        }

        // I can have another method for TaskParallel operations that each create a channel
        // Basically, this meants having a method be used for parallel that begins with:
        //   using var channel = _channelFactory.CreateChannel();

    }
}
