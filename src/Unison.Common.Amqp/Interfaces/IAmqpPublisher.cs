using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unison.Common.Amqp.DTO;

namespace Unison.Common.Amqp.Interfaces
{
    public interface IAmqpPublisher
    {
        void PublishMessage(AmqpMessage message);

        void PublishResponse(AmqpResponse response);
    }
}
