using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unison.Common.Amqp.Infrastructure.Client;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp.Infrastructure.Factories
{
    public class AmqpSubscriberFactory : IAmqpSubscriberFactory
    {
        private readonly IAmqpChannelFactory _channelFactory;
        private readonly ILoggerFactory _loggerFactory;

        public AmqpSubscriberFactory(IAmqpChannelFactory channelFactory, ILoggerFactory loggerFactory)
        {
            _channelFactory = channelFactory;
            _loggerFactory = loggerFactory;
        }

        public IAmqpSubscriber CreateSubscriber<T>(string queue, IAmqpSubscriptionWorker<T> worker)
        {
            return new AmqpSubscriber<T>(queue, worker, _channelFactory.CreateManagedChannel(), _loggerFactory.CreateLogger(CreateLoggerName(queue)));
        }

        private string CreateLoggerName(string queue)
        {
            return $"{nameof(IAmqpSubscriber)}-{queue}";
        }
    }
}
