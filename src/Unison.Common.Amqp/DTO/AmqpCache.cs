using System;
using System.Collections.Generic;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpCache : AmqpMessage
    {
        public IEnumerable<AmqpDataSet> Entities { get; set; }
    }
}
