using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpHeartbeat : AmqpMessage
    {
        public AmqpAgent Agent { get; set; }
    }
}
