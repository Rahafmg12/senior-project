
using Microsoft.AspNetCore.Mvc;
using Task_Login_Signup.DTOs;
using Task_Login_Singup.DTOs;
using Task_Login_Singup.Services;

namespace Task_Login_Singup.Controllers
{

    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }


        [HttpGet]
        [Route("login/{Email}/{Password}")]
        public async Task<IActionResult> Login(string Email,string Password)
        {
            var response = await _authenticationService.Login( Email,  Password);


            if (response.isError)
            {
                return Unauthorized(response);
            }

            // Add the token to the headers
            return Ok(response);
        }

        [HttpGet]
        [Route("register/{UserName}/{Email}/{Password}/{PhoneNumber}/{FirstName}/{LastName}/{Gender}/{DateOfBirth}")]
        public async Task<IActionResult> Register(string UserName, string Email, string Password, string PhoneNumber, string FirstName, string LastName, string Gender, DateTime DateOfBirth)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var response = await _authenticationService.Register( UserName,  Email,  Password,  PhoneNumber,FirstName,LastName,Gender, DateOfBirth);

            if (response.isError)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }

}
