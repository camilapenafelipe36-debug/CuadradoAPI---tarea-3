using Microsoft.AspNetCore.Mvc;

namespace CuadradoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class McdController : ControllerBase
    {
        [HttpGet("{dividendo}/{divisor}")]
        public IActionResult CalcularMCD(int dividendo, int divisor)
        {
            int a = dividendo;
            int b = divisor;

            while (b != 0)
            {
                int residuo = a % b;
                a = b;
                b = residuo;
            }

            return Ok(new
            {
                Dividendo = dividendo,
                Divisor = divisor,
                MCD = Math.Abs(a)
            });
        }
    }
}