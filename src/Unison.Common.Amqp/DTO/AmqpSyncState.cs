using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpSyncState
    {
        public IEnumerable<Dictionary<string, object>> Added { get; set; }
        public IEnumerable<Dictionary<string, object>> Updated { get; set; }
        public IEnumerable<Dictionary<string, object>> Deleted { get; set; }

    }
}
