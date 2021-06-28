using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp.Infrastructure.Factories
{
    public class AmqpConnectionFactory : IAmqpConnectionFactory
    {
        private const string _connectionString = "amqp://guest:guest@localhost:5672";
        private readonly IConnectionFactory _connectionFactory;

        public AmqpConnectionFactory()
        {
            _connectionFactory = new ConnectionFactory
            {
                Uri = new Uri(_connectionString)
            };
        }

        public IConnection CreateConnection()
        {
            return _connectionFactory.CreateConnection();
        }
    }
}
