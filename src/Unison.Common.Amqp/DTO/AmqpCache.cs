using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpCache : AmqpMessage
    {
        public IEnumerable<AmqpCachedEntity> Entities { get; set; }
    }

    public class AmqpCachedEntity
    {
        public string Entity { get; set; }
        public IEnumerable<Dictionary<string, object>> Data { get; set; }
    }
}
