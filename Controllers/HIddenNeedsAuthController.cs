using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HIddenNeedsAuthController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetValues()
        {
            return Ok(new { Value1 = "SecretValue1", Value2 = "SecretValue2" });
        }
    }
}
