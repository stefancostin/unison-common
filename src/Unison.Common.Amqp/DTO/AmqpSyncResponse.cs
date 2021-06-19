﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpSyncResponse : AmqpMessage
    {
        public AmqpAgent Agent { get; set; }
        public IEnumerable<Dictionary<string, object>> QueryResult { get; set; }
    }
}