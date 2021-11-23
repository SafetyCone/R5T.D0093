using System;

using R5T.D0081;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0093.I002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LoggerSynchronicityProvider"/> implementation of <see cref="ILoggerSynchronicityProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILoggerSynchronicityProvider> AddLoggerSynchronicityProviderAction(this IServiceAction _,
            IServiceAction<IExecutionSynchronicityProvider> executionSynchronicityProviderAction)
        {
            var serviceAction = _.New<ILoggerSynchronicityProvider>(services => services.AddLoggerSynchronicityProvider(
                executionSynchronicityProviderAction));

            return serviceAction;
        }
    }
}
