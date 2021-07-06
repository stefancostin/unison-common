using System;
using System.Collections.Generic;
using System.Linq;

namespace Unison.Common.Amqp.DTO
{
    [Serializable]
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

        public AmqpDataSet(string entity, string primaryKey, long version) : this(entity, primaryKey)
        {
            Version = version;
        }

        public string Entity { get; set; }
        public string PrimaryKey { get; set; }
        public long Version { get; set; }
        public IDictionary<string, AmqpRecord> Records { get; set; }

        public bool IsEmpty()
        {
            if (Records == null)
                return true;

            return !Records.Any((KeyValuePair<string, AmqpRecord> record) => record.Value != null && !record.Value.IsEmpty());
        }
    }

    [Serializable]
    public class AmqpRecord
    {
        public AmqpRecord()
        {
            Fields = new Dictionary<string, AmqpField>();
        }

        public IDictionary<string, AmqpField> Fields { get; set; }

        public bool IsEmpty()
        {
            if (Fields == null)
                return true;

            return !Fields.Any();
        }
    }

    [Serializable]
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
