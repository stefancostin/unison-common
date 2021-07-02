using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace Unison.Common.Amqp.DTO
{
    public class AmqpMessage 
    {
        public string? CorrelationId { get; set; }
    }
}
