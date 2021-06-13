using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;
using Unison.Common.Amqp.Interfaces;
using Unison.Common.Amqp.Models.DTO;

namespace Unison.Common.Amqp.Infrastructure.Client
{
    public class AmqpPublisher : IAmqpPublisher
    {
        private readonly IAmqpManagedChannel _channel;

        private const string responseExchange = "unison.responses";

        private const string exchange = "unison.commands";
        private const string queue = "unison.commands.sync";

        public AmqpPublisher(IAmqpChannelFactory channelFactory)
        {
            _channel = channelFactory.CreateManagedChannel();
        }

        public void PublishMessage(AmqpMessage message)
        {
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            _channel.GetChannel().BasicPublish(exchange: exchange,
                                               routingKey: queue,
                                               basicProperties: null,
                                               body: body);
        }

        public void PublishResponse(AmqpResponse response)
        {
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response));

            _channel.GetChannel().BasicPublish(exchange: responseExchange,
                                               routingKey: responseExchange,
                                               basicProperties: null,
                                               body: body);
        }

        // I can have another method for TaskParallel operations that each create a channel
        // Basically, this meants having a method be used for parallel that begins with:
        //   using var channel = _channelFactory.CreateChannel();

    }
}
