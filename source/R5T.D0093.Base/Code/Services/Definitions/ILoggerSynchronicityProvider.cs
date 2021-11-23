using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0093
{
    /// <summary>
    /// Provides the synchronicity that should be used for logging operations.
    /// Generally, logging should be synchronous in development, and asynchronous in production.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ILoggerSynchronicityProvider : IServiceDefinition
    {
        Task<Synchronicity> GetLoggerSynchronicity();
    }
}
