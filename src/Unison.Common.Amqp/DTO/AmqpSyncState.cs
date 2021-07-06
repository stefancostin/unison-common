using System;
using System.Collections.Generic;
using System.Linq;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
    public class AmqpSyncState
    {
        public string Entity { get; set; }
        public long Version { get; set; }
        public AmqpDataSet Added { get; set; }
        public AmqpDataSet Updated { get; set; }
        public AmqpDataSet Deleted { get; set; }

        public bool IsEmpty()
        {
            return (new List<AmqpDataSet>() { Added, Updated, Deleted }).All(ds => ds == null || ds.IsEmpty());
        }
    }
}
