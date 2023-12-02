using Microsoft.AspNetCore.Mvc;

namespace Middlewares.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TestController :ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            int a = 0;
            int b = 10 / a;

            return "Ok";
        }
    }
}
