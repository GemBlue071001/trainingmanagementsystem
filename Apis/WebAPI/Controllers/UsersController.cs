using Application.Interfaces;
using Application.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Commons;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IClaimsService _claimsService;
        public readonly ApiResponse _apiResponse;

        public UsersController(IUserService userService, IClaimsService claimsService)
        {
            _userService = userService;
            _claimsService = claimsService;
            _apiResponse = new ApiResponse();
        }

        #region CRUD User For SuperAdmin
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var serviceResponse = await _userService.GetAllUsersAsync();
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest(_apiResponse.SetBadRequest(serviceResponse.Result));
            }
            return Ok(_apiResponse.SetOk(serviceResponse.Result));
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var serviceResponse = await _userService.GetUserByIdAsync(id);
            if(!serviceResponse.IsSuccess)
            {
                return BadRequest(_apiResponse.SetBadRequest(serviceResponse.Result));
            }
            return Ok(_apiResponse.SetOk(serviceResponse.Result));
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserUpdateDTO userUpdate)
        {
            var serviceResponse = await _userService.UpdateUserAsync(id, userUpdate);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest(_apiResponse.SetBadRequest(serviceResponse.Result));
            }
            return Ok(_apiResponse.SetOk(serviceResponse.Result));
        }
        #endregion

        [Authorize]
        [HttpGet("GetMe")]
        public async Task<IActionResult> GetMe()
        {
            int userId = _claimsService.GetCurrentUserId;
            var serviceResponse = await _userService.GetUserByIdAsync(userId);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest(_apiResponse.SetBadRequest(serviceResponse.Result));
            }
            return Ok(_apiResponse.SetOk(serviceResponse.Result));
        }

        [Authorize]
        [HttpPut("UpdateMe")]
        public async Task<IActionResult> UpdateMe(UserUpdateMeDTO user)
        {
            //validation for user
            int userId = _claimsService.GetCurrentUserId;
            var serviceResponse = await _userService.UpdateMeAsync(userId, user);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest(_apiResponse.SetBadRequest(serviceResponse.Result));
            }
            return Ok(_apiResponse.SetOk(serviceResponse.Result));
        }
    }
}