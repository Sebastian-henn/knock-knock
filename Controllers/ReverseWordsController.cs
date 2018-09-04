using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseWordsController : ControllerBase
    {
        // GET api/ReverseWords
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery(Name = "sentence")] string sentence)
        {
            string result = reverseWords(sentence);
            return Ok(result);
        }

        public string reverseWords(string sentence)
        {
            var reversedWords = String.Join(" ", sentence.Split(' ')
                             .Select(word => new String(word.Reverse().ToArray()))
                             .ToArray());

            return reversedWords;
        }
    }
}
