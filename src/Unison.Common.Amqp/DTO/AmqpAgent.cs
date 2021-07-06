using System;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpAgent
    {
        public string InstanceId { get; set; }
        public string NodeId { get; set; }
    }
}
