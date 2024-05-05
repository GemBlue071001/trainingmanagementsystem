using Application.Interfaces;
using Application.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Commons;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ApiResponse _response;

        public AuthController(IUserService userService)
        {
            _userService = userService;
            _response = new ApiResponse();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDTO user)
        {
            //Validation user
            var serviceResponse = await _userService.LoginAsync(user);
            if (serviceResponse.IsSuccess) 
            {
                return Ok(_response.SetOk(serviceResponse.Result));
            }
            return BadRequest(_response.SetBadRequest(message: serviceResponse.Message));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserCreateDTO user)
        {
            //Validation user
            var serviceResponse = await _userService.CreateUserAsync(user);
            if (serviceResponse.IsSuccess)
            {
                return Ok(_response.SetOk(serviceResponse.Result));
            }
            return BadRequest(_response.SetBadRequest(message: serviceResponse.Message));
        }
    }
}
