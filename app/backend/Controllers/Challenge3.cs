using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge3Controller : Controller
    {
        [HttpPost("phone-directory")]
        public string Challenge3([FromBody] Challenge3Model input)
        {
            var phoneNumber = input.Number;
            var phoneDirectory = input.PhoneDirectory;

            // Write your code here

            return "";
        }
    }
}
