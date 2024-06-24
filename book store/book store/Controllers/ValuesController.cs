using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

namespace book_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/values/talha/{id}
        [HttpGet("talha/{id}")]
        public IActionResult Get(int id)
        {
            if (id > 5)

            {
                return Ok(1); // Return HTTP 200 OK with the value 1
            }
            else
                return NotFound();
        }
    }
}
