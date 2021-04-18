using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Sample.Eto;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Entities.Events.Distributed;

namespace Test.Sample
{
    [AutoMap(typeof(Sample))]
    public class SampleEto : EntityEto
    {
        public string Message { get; set; }
    }
}
