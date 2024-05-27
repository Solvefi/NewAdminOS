using Microsoft.AspNetCore.Mvc;

namespace AdminOS.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class HealthCheckController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(new { status = "Healthy" });
            }
        }
    
}
