using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.Interfaces
{
    public interface IAmqpConnectionFactory
    {
        IConnection CreateConnection();
    }
}
