using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResult.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("1")]
        public IEnumerable<string> GetValuesEnumerable()
        {
            return new[]
            {
                "hello", "world"
            };
        }

        [HttpGet("2")]
        public IActionResult GetValuesIActionResult()
        {
            var values = new[]
            {
                "hello", "world"
            };

            return Ok(values);
        }
        
        [HttpGet("3")]
        public ActionResult<IEnumerable<string>> GetValuesActionResult()
        {
            return new[]
            {
                "hello", "world"
            };
        }
    }
}