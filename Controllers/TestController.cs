using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingAPI.Models;

namespace TestingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        private static readonly string[] Summaries = new[]
        {
            "Kaushi", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [Route("kaushi")]
        public ActionResult Testing()
        {

            return Ok(Summaries);
        }

        [HttpPost]
        [Route("create/kaushi")]
        public ActionResult testPost(Customer cus)
        {
            if (cus == null)
            {
                return BadRequest("404");
            }
            return Ok(cus);
        }
    }
}
