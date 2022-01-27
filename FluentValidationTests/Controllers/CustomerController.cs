using FluentValidation.Results;
using FluentValidationTests.Entities;
using FluentValidationTests.Validations;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationTests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public CustomerController() { }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            var validator = new CustomerValidator();

            ValidationResult results = validator.Validate(customer);

            if (results.IsValid)
                return Ok(customer);
            else
                return BadRequest(results.ToString());
        }
    }
}
