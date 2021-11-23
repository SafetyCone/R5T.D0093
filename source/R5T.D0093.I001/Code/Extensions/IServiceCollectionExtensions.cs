using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Magyar;


namespace R5T.D0093.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedLoggerSynchronicityProvider"/> implementation of <see cref="ILoggerSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedLoggerSynchronicityProvider(this IServiceCollection services,
            Synchronicity synchronicity)
        {
            services.AddSingleton<ILoggerSynchronicityProvider>(new ConstructorBasedLoggerSynchronicityProvider(
                synchronicity));

            return services;
        }
    }
}
