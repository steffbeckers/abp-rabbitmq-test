using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace Test.Sample
{
    public class SampleTestEventHandler : IDistributedEventHandler<TestEventEto>, ITransientDependency
    {
        private readonly ILogger<SampleTestEventHandler> _logger;

        public SampleTestEventHandler(ILogger<SampleTestEventHandler> logger)
        {
            _logger = logger;
        }

        public Task HandleEventAsync(TestEventEto eventData)
        {
            _logger.LogInformation($"TEST EVENT RECEIVED => Message: {eventData.Message}");
            return Task.CompletedTask;
        }
    }
}
