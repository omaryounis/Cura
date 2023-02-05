using JWT.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VipCharacterController : ControllerBase
    {
        private readonly IVipCharacterService _VipCharacterService;
        public VipCharacterController(IVipCharacterService VipCharacterService)
        {
            _VipCharacterService = VipCharacterService;
        }
        [HttpGet]
        [Authorize(Policy = "Vip")]
        public async Task<ActionResult> Get()
        {
            return Ok(await _VipCharacterService.GetModificationPage());
        }
    }
}
