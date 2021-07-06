using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpSyncResponse : AmqpMessage
    {
        public AmqpAgent Agent { get; set; }
        public AmqpSyncState State { get; set; }
    }
}
