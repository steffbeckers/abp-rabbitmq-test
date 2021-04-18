using AutoMapper;
using Test.Sample;

namespace Test
{
    public class TestApplicationAutoMapperProfile : Profile
    {
        public TestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Sample.Sample, SampleEto>()
                .ForMember(x => x.EntityType, x => x.Ignore())
                .ForMember(x => x.KeysAsString, x => x.Ignore())
                .ForMember(x => x.Properties, x => x.Ignore());
        }
    }
}
