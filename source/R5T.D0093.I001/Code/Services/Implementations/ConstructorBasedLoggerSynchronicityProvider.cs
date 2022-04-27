using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0093.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedLoggerSynchronicityProvider : ILoggerSynchronicityProvider, IServiceImplementation
    {
        private Synchronicity Synchronicity { get; }


        public ConstructorBasedLoggerSynchronicityProvider(
            [NotServiceComponent] Synchronicity synchronicity)
        {
            this.Synchronicity = synchronicity;
        }

        public Task<Synchronicity> GetLoggerSynchronicity()
        {
            return Task.FromResult(this.Synchronicity);
        }
    }
}
