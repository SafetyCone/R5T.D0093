using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0081;
using R5T.T0063;


namespace R5T.D0093.I002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LoggerSynchronicityProvider"/> implementation of <see cref="ILoggerSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLoggerSynchronicityProvider(this IServiceCollection services,
            IServiceAction<IExecutionSynchronicityProvider> executionSynchronicityProviderAction)
        {
            services
                .Run(executionSynchronicityProviderAction)
                .AddSingleton<ILoggerSynchronicityProvider, LoggerSynchronicityProvider>();

            return services;
        }
    }
}