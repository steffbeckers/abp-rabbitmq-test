using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
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

    public class SampleTestDomainEventHandler : IDistributedEventHandler<TestDomainEventEto>, ITransientDependency
    {
        private readonly ILogger<SampleTestDomainEventHandler> _logger;

        public SampleTestDomainEventHandler(ILogger<SampleTestDomainEventHandler> logger)
        {
            _logger = logger;
        }

        public Task HandleEventAsync(TestDomainEventEto eventData)
        {
            _logger.LogInformation($"TEST DOMAIN EVENT RECEIVED => Message: {eventData.Message}");
            return Task.CompletedTask;
        }
    }

    public class SampleEntityCreatedEventHandler : IDistributedEventHandler<EntityCreatedEto<SampleEto>>, ITransientDependency
    {
        private readonly ILogger<SampleEntityCreatedEventHandler> _logger;

        public SampleEntityCreatedEventHandler(ILogger<SampleEntityCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task HandleEventAsync(EntityCreatedEto<SampleEto> eventData)
        {
            _logger.LogInformation($"TEST ENTITY CREATED EVENT RECEIVED => Message: {eventData.Entity.Message}");
            return Task.CompletedTask;
        }
    }
}
