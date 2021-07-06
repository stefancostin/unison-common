using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpApplyVersion : AmqpMessage
    {
        public string Entity { get; set; }
        public long Version { get; set; }
    }
}
