using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
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
        private readonly IAmqpConnectionFactory _connectionFactory;
        private IConnection _connection;

        public AmqpChannelFactory(IAmqpConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            _connection = connectionFactory.CreateConnection();
        }

        public IAmqpManagedChannel CreateManagedChannel()
        {
            return new AmqpManagedChannel(_connection.CreateModel(), this);
        }

        public IModel CreateUnmanagedChannel()
        {
            try
            {
                return _connection.CreateModel();
            }
            catch (AlreadyClosedException ex)
            {
                _connection = _connectionFactory.CreateConnection();
                return _connection.CreateModel();
            }
        }

        ~AmqpChannelFactory()
        {
            _connection?.Close();
            _connection?.Dispose();
        }
    }
}
