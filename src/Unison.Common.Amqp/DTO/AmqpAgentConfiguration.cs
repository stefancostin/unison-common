using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpAgentConfiguration : AmqpMessage
    {
        public int HeartbeatTimer { get; set; }
    }
}
