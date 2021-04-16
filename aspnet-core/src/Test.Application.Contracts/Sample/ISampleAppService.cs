using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Test.Sample
{
    public interface ISampleAppService : IApplicationService
    {
        Task SendTestEvent();
    }
}
