using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGameController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
            return Ok("Board Screen");
        }
    }
}
