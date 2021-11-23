using System;

using R5T.Magyar;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0093.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedLoggerSynchronicityProvider"/> implementation of <see cref="ILoggerSynchronicityProvider"/>.
        /// </summary>
        public static IServiceAction<ILoggerSynchronicityProvider> AddConstructorBasedLoggerSynchronicityProviderAction(this IServiceAction _,
            Synchronicity synchronicity)
        {
            var output = _.New<ILoggerSynchronicityProvider>(services => services.AddConstructorBasedLoggerSynchronicityProvider(
                synchronicity));

            return output;
        }
    }
}
