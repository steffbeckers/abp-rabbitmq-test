using System;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace Test.Sample
{
    public class SampleAppService : ApplicationService, ISampleAppService
    {
        private readonly IRepository<Sample> _sampleRepository;
        private readonly IDistributedEventBus _distributedEventBus;

        public SampleAppService(
            IRepository<Sample> sampleRepository,
            IDistributedEventBus distributedEvent
        )
        {
            _sampleRepository = sampleRepository;
            _distributedEventBus = distributedEvent;
        }

        public async Task SendTestEvent()
        {
            await _distributedEventBus.PublishAsync(
                new TestEventEto()
                {
                    Message = "This is the message of the test event"
                }
            );
        }

        public async Task CreateTestSample()
        {
            await _sampleRepository.InsertAsync(new Sample()
            {
                Message = $"Sample added on {DateTime.Now}"
            });
        }
    }
}
