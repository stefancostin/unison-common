using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpSyncRequest : AmqpMessage
    {
        public string Entity { get; set; }
        public string PrimaryKey { get; set; }
        public IEnumerable<string> Fields { get; set; }
    }
}
