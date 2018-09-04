using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        // GET api/Fibonacci
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery(Name = "n")] string n)
        {
            try
            {
                int nInt = 0;
                if (int.TryParse(n, out nInt)) {
                    int result = fibonacciCalculator(nInt);
                    return Ok(result);
                } else {
                    string message =  "The request is invalid.";
                    return BadRequest(new { message });
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        public int fibonacciCalculator(int n)
        {
            if (n > 92)
                throw new ArgumentException();

            if (n == 0)
                return 0;

            if (n <= -1)
                return (int)Math.Pow(-1, n + 1) * fibonacciCalculator(-n);

            int a = 1;
            int b = 1;

            for (int i = 0; i < (n - 1); i++)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return a;
        }
    }
}
