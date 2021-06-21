using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.DTO
{
    public class AmqpDataSet
    {
        public AmqpDataSet()
        {
            Records = new List<AmqpRecord>();
        }

        public string Entity { get; set; }
        public IEnumerable<AmqpRecord> Records { get; set; }
    }

    public class AmqpRecord
    {
        public AmqpRecord()
        {
            Fields = new List<AmqpField>();
        }

        public string PrimaryKey { get; set; }
        public IEnumerable<AmqpField> Fields { get; set; }
    }

    public class AmqpField
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public object Value { get; set; }
    }
}
