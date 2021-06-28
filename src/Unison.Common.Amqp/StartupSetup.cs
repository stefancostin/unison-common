using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unison.Common.Amqp.Infrastructure.Client;
using Unison.Common.Amqp.Infrastructure.Factories;
using Unison.Common.Amqp.Interfaces;

namespace Unison.Common.Amqp
{
    public static class StartupSetup
    {
        public static void AddAmqpInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IAmqpConnectionFactory, AmqpConnectionFactory>();
            services.AddSingleton<IAmqpChannelFactory, AmqpChannelFactory>();
            services.AddScoped<IAmqpSubscriberFactory, AmqpSubscriberFactory>();
            services.AddTransient<IAmqpPublisher, AmqpPublisher>();
        }
    }
}
