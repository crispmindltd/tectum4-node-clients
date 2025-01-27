using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tectum.PublicBlockChainClient.Config;

namespace Tectum.PublicBlockChainClient.Registries
{
    public static class ClientRegistry
    {
        public static IServiceCollection AddPublicBlockChainClient(this IServiceCollection services,
            IConfiguration configuration,
            string configName = "TectumLNodeClientConfig")
        {
            services.Configure<PublicBlockChainClientConfig>(configuration.GetSection(configName).Bind);
            services
                .AddHttpClient<IPublicBlockChainClient, PublicBlockChainClient>(
                    (client, service) =>
                    {
                        var config = service.GetService<IOptions<PublicBlockChainClientConfig>>();
                        if (config == null)
                        {
                            throw new AggregateException("Configuration is disabled");
                        }

                        client.BaseAddress = new Uri(config.Value.BaseUrl);
                        return new PublicBlockChainClient(client);
                    });

            return services;
        }
    }
}