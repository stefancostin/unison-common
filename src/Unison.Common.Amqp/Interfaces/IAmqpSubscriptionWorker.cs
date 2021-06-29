using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unison.Common.Amqp.Interfaces
{
    public interface IAmqpSubscriptionWorker<T>
    {
        IServiceScope ServiceScope { get; set; }
        public void ProcessMessage(T message);
    }
}
