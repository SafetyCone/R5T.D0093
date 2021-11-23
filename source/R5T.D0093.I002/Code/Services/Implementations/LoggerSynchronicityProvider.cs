using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.D0081;
using R5T.T0064;


namespace R5T.D0093.I002
{
    [ServiceImplementationMarker]
    public class LoggerSynchronicityProvider : ILoggerSynchronicityProvider, IServiceImplementation
    {
        private IExecutionSynchronicityProvider ExecutionSynchronicityProvider { get; }


        public LoggerSynchronicityProvider(IExecutionSynchronicityProvider executionSynchronicityProvider)
        {
            this.ExecutionSynchronicityProvider = executionSynchronicityProvider;
        }

        public async Task<Synchronicity> GetLoggerSynchronicity()
        {
            var output = await this.ExecutionSynchronicityProvider.GetExecutionSynchronicity();
            return output;
        }
    }
}