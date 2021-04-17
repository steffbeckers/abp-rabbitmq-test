using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.Domain.Entities.Auditing;

namespace Test.Sample
{
    public class Sample : FullAuditedAggregateRoot<Guid>
    {
        public string Message { get; set; }

        public void Test()
        {
            AddDistributedEvent(new TestDomainEventEto() { Message = Message });
        }
    }
}
