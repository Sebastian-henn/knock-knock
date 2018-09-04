using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        // GET api/Token
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Guid result = new Guid("eb0c71cc-2d14-49ce-99ed-2f5e335accf3");
            return Ok(result);
        }
    }
}
