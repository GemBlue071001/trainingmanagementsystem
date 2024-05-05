using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.ViewModels.TrainingClasses;
using FluentValidation;
using WebAPI.Commons;

namespace WebAPI.Controllers
{
    [Route("api/trainingClasses")]
    [ApiController]
    public class TrainingClasssesController : ControllerBase
    {
        private ITrainingClassService _classService;
        private readonly IValidator<TrainingClassCreateDTO> _validator;
        private readonly ApiResponse apiResponse;

        public TrainingClasssesController(ITrainingClassService classService, IValidator<TrainingClassCreateDTO> validator)
        {
            _classService = classService;
            _validator = validator;
            apiResponse = new ApiResponse ();
        }

        [HttpGet]
        public async Task<IActionResult> GetClassesAsync(int pageIndex = 1,
            int pageSize = 3,
            string? search = null,
            DateTime createOnStart = default,
            DateTime createOnEnd = default)
        {
            var list = await _classService.GetClassesAysnc(pageIndex, pageSize, search, createOnStart, createOnEnd);
            
            return Ok(apiResponse.SetOk(list));
        }

        [HttpPost]
        public async Task<IActionResult> CreateClassAsync(TrainingClassCreateDTO request)
        {
            var res = _validator.Validate(request);
            if (!res.IsValid) return  BadRequest(apiResponse.SetBadRequest( message: res.ToString("\n")));
            await _classService.CreateClassAsync(request);
            return Ok();
        }
        [HttpPut("infomation")]
        public async Task<IActionResult> UpdateClassInfomationAsync(TrainingClassInfomationUpdateDTO request)
        {
            await _classService.UpdateClassInfomationAsync(request);
            return Ok();
        }
        [HttpPut("status")]
        public async Task<IActionResult> UpdateClassStatusAsync(TrainingClassStatusUpdateDTO request)
        {
            await _classService.UpdateClassStatusAsync(request);
            return Ok();
        }
        [HttpPut("reviewer")]
        public async Task<IActionResult> UpdateClassReviewerAsync(TrainingClassReviewUpdateDTO request)
        {
            await _classService.UpdateClassReviewerAsync(request);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassDetailAsync(int id)
        {
            var _class = await _classService.GetTrainingClassDetailAsync(id);
            return Ok(_class);
        }
        [HttpPatch("{id}/deactivate")]
        public async Task<IActionResult> SoftDeleteClassDetailAsync(int id)
        {
            await _classService.SoftDeleteClassAsync(id);
            return Ok();
        }
        [HttpPatch("{id}/restoration")]
        public async Task<IActionResult> RestoreDeleteClassDetailAsync(int id)
        {
            await _classService.RestoreClassAsync(id);
            return Ok();
        }

    }
}
