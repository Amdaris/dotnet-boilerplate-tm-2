using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge1Controller : Controller
    {
        [HttpPost("odd-ones-out")]
        public int[] Challenge1([FromBody] Challenge1Model input)
        {
            var numbers = input.Numbers;

            // Write your code here

            return [];
        }
    }
}
