using DecoderDesignPatternSample.Computers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoderDesignPatternSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {

        [HttpGet]
        public IActionResult TestDecoderMethod()
        {
            DellLaptop dellLaptop = new DellLaptop();
            dellLaptop.OpenLid();

            return Ok("tamamdır"); 
        }

    }
}
