using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleTypeController : ControllerBase
    {
        // GET api/TriangleType
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(
            [FromQuery(Name = "a")] string a,
            [FromQuery(Name = "b")] string b,
            [FromQuery(Name = "c")] string c
        )
        {
            try
            {
                var result = TriangleType(int.Parse(a), int.Parse(b), int.Parse(c));
                return Ok(result);
            } catch {
                var message =  "The request is invalid.";
                return BadRequest(new { message });
            }

        }

        public String TriangleType(int a, int b, int c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                return "Error";

            if ((a == b) && (b == c))
                return "Equilateral";


            if ((a == b) || (a == c) || (b == c))
                return "Isosceles";

            return "Scalene";
        }
    }
}
