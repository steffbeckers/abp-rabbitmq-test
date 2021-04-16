using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.Application.Services;
using Volo.Abp.EventBus.Distributed;

namespace Test.Sample
{
    public class SampleAppService : ApplicationService, ISampleAppService
    {
        private readonly IDistributedEventBus _distributedEventBus;

        public SampleAppService(IDistributedEventBus distributedEvent)
        {
            _distributedEventBus = distributedEvent;
        }

        public async Task SendTestEvent()
        {
            await _distributedEventBus.PublishAsync(
                new TestEventEto() {
                    Message = "This is the message of the test event"
                }
            );
        }
    }
}
