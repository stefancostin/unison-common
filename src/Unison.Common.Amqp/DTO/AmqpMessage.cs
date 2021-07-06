using System;

#nullable enable

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpMessage 
    {
        public string? CorrelationId { get; set; }
    }
}
