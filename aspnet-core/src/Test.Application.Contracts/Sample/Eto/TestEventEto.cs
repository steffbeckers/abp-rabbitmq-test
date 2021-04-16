using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EventBus;

namespace Test.Sample.Eto
{
    [EventName("Test.Sample.TestEvent")]
    public class TestEventEto
    {
        public string Message { get; set; }
    }
}
