using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service) => _service = service;

        [HttpPost("login")]

        public async Task<IActionResult> Authenticate([FromBody] AuthorizeDto authorizeDto)
        {
            if (!await _service.AuthenticationService.ValidateUser(authorizeDto))
                return Unauthorized();

            var roless = await _service.AuthenticationService.GetRolesByUserEmail(authorizeDto.Email);
            return Ok(new
            {
                token = await _service.AuthenticationService.CreateToken(),
                email = authorizeDto.Email,
                roles = roless
            });
        }

        [HttpPost("registration")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] AuthorizeDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }
    }
}
