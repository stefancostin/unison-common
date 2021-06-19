using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpConnected : AmqpMessage
    {
        public AmqpAgent Agent { get; set; }
    }
}
