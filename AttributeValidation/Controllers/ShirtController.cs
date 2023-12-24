using AttributeValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShirtController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            return Ok();
        }
    }
}
