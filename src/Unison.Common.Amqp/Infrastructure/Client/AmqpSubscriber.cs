using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unison.Common.Amqp.DTO;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp.Infrastructure.Client
{
    public class AmqpSubscriber<T> : IAmqpSubscriber
    {
        private readonly string _queue;
        private readonly IAmqpSubscriptionWorker<T> _worker;
        private readonly IAmqpManagedChannel _channel;
        private readonly ILogger _logger;

        public AmqpSubscriber(string queue, IAmqpSubscriptionWorker<T> worker, IAmqpManagedChannel channel, ILogger logger)
        {
            _queue = queue;
            _worker = worker;
            _channel = channel;
            _logger = logger;
        }

        public void Subscribe()
        {
            var consumer = new EventingBasicConsumer(_channel.GetChannel());

            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(body));
                _worker.ProcessMessage(message);
            };

            _channel.GetChannel().BasicConsume(queue: _queue, autoAck: true, consumer: consumer);

            _logger.LogInformation("Thread {0}. Started consuming...", Thread.CurrentThread.ManagedThreadId);
        }

        public void Unsubscribe()
        {
            _channel?.Dispose();
        }

        ~AmqpSubscriber()
        {
            Unsubscribe();
        }
    }
}
