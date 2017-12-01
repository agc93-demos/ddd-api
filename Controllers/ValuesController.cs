using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ddd_api.Controllers
{
    [Route("api/ddd")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("{location}")]
        public IActionResult Get(string location)
        {
            switch (location.ToLower())
            {
                case "bne":
                case "brisbane":
                    return Ok(new{
                        Location = "UQ, St Lucia",
                        Date = DateTime.Today.ToShortDateString(),
                        IsBestCity = true
                    });
                case "syd":
                case "sydney":
                    return Ok(new {
                        Location = "UTS, Sydney",
                        Date = new DateTime(2017,7,15).ToShortDateString(),
                        IsBestCity = false
                    });
                default:
                    return NotFound();
            }
        }
    }
}
