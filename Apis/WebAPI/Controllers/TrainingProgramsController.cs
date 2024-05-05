using Application.Interfaces;
using Application.ViewModels.TrainingProgramViewModels;
using Domain.Enums; 
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramsController : ControllerBase
    {
        private readonly ITrainingProgramService _trainingProgramService;
        public TrainingProgramsController(ITrainingProgramService trainingProgramService)
        {
            _trainingProgramService = trainingProgramService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTrainingProgramsAsync([FromQuery] string? keyword = null,
                                                     [FromQuery] int pageSize = 0,
                                                     [FromQuery] int pageIndex = 1,
                                                     [FromQuery] SortType sortType = SortType.Ascending)
        {
            var serviceResponse = await _trainingProgramService.GetAllTrainingProgramAdvanceAsync(s => s.Name.Contains(keyword ?? "") && s.IsDeleted == false, pageSize, pageIndex, sortType);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(serviceResponse.Result);
        }
        [HttpGet("WithSyllabus")]
        public async Task<IActionResult> GetAllTrainingProgramsWithProgramSyllabusAsync([FromQuery] string? keyword = null,
                                             [FromQuery] int pageSize = 0,
                                             [FromQuery] int pageIndex = 1,
                                             [FromQuery] SortType sortType = SortType.Ascending)
        {
            var serviceResponse = await _trainingProgramService.GetAllTrainingProgramsWithProgramSyllabusAdvanceAsync(s => s.Name.Contains(keyword ?? "") && s.IsDeleted == false, pageSize, pageIndex, sortType);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(serviceResponse.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrainingProgramByIdAsync(int id)
        {
            var serviceResponse = await _trainingProgramService.GetTrainingProgramByIdAsync(id);
            if (!serviceResponse.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(serviceResponse.Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainingProgramAsync([FromBody] TrainingProgramCreateDTO createDTO)
        {
            var serviceResponse = await _trainingProgramService.CreateTrainingProgramAsync(createDTO);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpPost("{id}/Syllabus")]
        public async Task<IActionResult> AddOneSyllabusToTrainingProgram(int syllabusId, int trainingProgramId)
        {
            var serviceResponse = await _trainingProgramService.AddOneSyllabusToTrainingProgramAsync(syllabusId, trainingProgramId);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpDelete("{id}/Syllabus")]
        public async Task<IActionResult> RemnoveOneSyllabusToTrainingProgram(int syllabusId, int trainingProgramId)
        {
            var serviceResponse = await _trainingProgramService.RemoveOneSyllabusToTrainingProgramAsync(syllabusId, trainingProgramId);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TrainingProgramUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
                return BadRequest();
            var serviceResponse = await _trainingProgramService.UpdateTrainingProgramAsync(updateDTO);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return NotFound(serviceResponse.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var serviceResponse = await _trainingProgramService.DeleteTrainingProgramAsync(id);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return NotFound(serviceResponse.Message);
        }

    }
}
