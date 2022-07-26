namespace RabbitMq;

using Core.AsyncMessaging;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRabbitMq(this IServiceCollection services, RabbitMqConfiguration config)
    {
        services.AddSingleton(config);
        services.AddSingleton<IMessageBusClient, MessageBusClient>();
        
        return services;
    }
}
