using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpConnected : AmqpMessage
    {
        public AmqpAgent Agent { get; set; }
    }
}
