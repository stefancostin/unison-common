using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpApplyVersion : AmqpMessage
    {
        public string Entity { get; set; }
        public long Version { get; set; }
    }
}
