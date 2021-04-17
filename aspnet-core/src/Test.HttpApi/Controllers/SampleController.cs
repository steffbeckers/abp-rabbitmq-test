using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test.Sample;

namespace Test.Controllers
{
    [Route("api/app/sample")]
    public class SampleController : TestController
    {
        private readonly ISampleAppService _sampleAppService;

        public SampleController(ISampleAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }

        [HttpGet]
        [Route("send-test-event")]
        public async Task<IActionResult> SendTestEvent()
        {
            await _sampleAppService.SendTestEvent();
            return Ok();
        }

        [HttpGet]
        [Route("create-test-sample")]
        public async Task<IActionResult> CreateTestSample()
        {
            await _sampleAppService.CreateTestSample();
            return Ok();
        }
    }
}
