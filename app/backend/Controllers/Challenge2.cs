using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge2Controller : Controller
    {
        [HttpPost("equal-sides")]
        public int Challenge2([FromBody] Challenge2Model input)
        {
            var numbers = input.Numbers;

            // Write your code here

            return -1;
        }
    }
}
