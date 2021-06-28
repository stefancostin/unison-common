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
            Records = new Dictionary<string, AmqpRecord>();
        }

        public AmqpDataSet(string entity, string primaryKey) : this()
        {
            Entity = entity;
            PrimaryKey = primaryKey;
        }

        public string Entity { get; set; }
        public string PrimaryKey { get; set; }
        public IDictionary<string, AmqpRecord> Records { get; set; }
    }

    public class AmqpRecord
    {
        public AmqpRecord()
        {
            Fields = new Dictionary<string, AmqpField>();
        }

        public IDictionary<string, AmqpField> Fields { get; set; }
    }

    public class AmqpField
    {
        public AmqpField() { }

        public AmqpField(string name, Type type, object value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public string Name { get; set; }
        public Type Type { get; set; }
        public object Value { get; set; }
    }
}
