using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}