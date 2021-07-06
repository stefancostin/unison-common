using System;
using System.Collections.Generic;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpSyncRequest : AmqpMessage
    {
        public string Entity { get; set; }
        public string PrimaryKey { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }
}
