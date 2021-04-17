using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EventBus;

namespace Test.Sample.Eto
{
    [EventName("Test.Sample.TestDomainEvent")]
    public class TestDomainEventEto
    {
        public string Message { get; set; }
    }
}
