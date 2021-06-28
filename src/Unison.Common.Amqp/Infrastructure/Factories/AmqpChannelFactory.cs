using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unison.Common.Amqp.Infrastructure.Models;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp.Infrastructure.Factories
{
    public class AmqpChannelFactory : IAmqpChannelFactory
    {
        private readonly IConnection _connection;

        public AmqpChannelFactory(IAmqpConnectionFactory connectionFactory)
        {
            _connection = connectionFactory.CreateConnection();
        }

        public IAmqpManagedChannel CreateManagedChannel()
        {
            return new AmqpManagedChannel(_connection.CreateModel(), this);
        }

        public IModel CreateUnmanagedChannel()
        {
            return _connection.CreateModel();
        }

        ~AmqpChannelFactory()
        {
            _connection?.Close();
            _connection?.Dispose();
        }
    }
}
