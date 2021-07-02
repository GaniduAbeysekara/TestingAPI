namespace TestingAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using TestingAPI.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private List<Customer> customers;
        public CustomerController()
        {

        }

        [HttpGet]
        [Route("getCustomers")]
        public ActionResult getAllCustomers()
        {

            return Ok(customers);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult addCustomers(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("404");
            }
            return Ok(customer);
        }
    }
}
