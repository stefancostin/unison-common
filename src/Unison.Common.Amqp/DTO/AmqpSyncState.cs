using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpSyncState
    {
        public AmqpDataSet Added { get; set; }
        public AmqpDataSet Updated { get; set; }
        public AmqpDataSet Deleted { get; set; }
    }
}
