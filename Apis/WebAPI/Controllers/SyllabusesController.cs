using Application.Interfaces;
using Application.ViewModels.Syllabus;
using Domain.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyllabusesController : ControllerBase
    {
        private readonly ISyllabusService _syllabusService;
        private readonly IValidator<SyllabusCreateDTO> _syllabusCreateValidator;
        private readonly IValidator<SyllabusUpdateDTO> _syllabusUpdateValidator;

        public SyllabusesController(ISyllabusService syllabusService, IValidator<SyllabusCreateDTO> syllabusCreateValidator, IValidator<SyllabusUpdateDTO> syllabusUpdateValidator)
        {
            _syllabusService = syllabusService;
            _syllabusCreateValidator = syllabusCreateValidator;
            _syllabusUpdateValidator = syllabusUpdateValidator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSyllabusAsync([FromQuery] string? keyword = null,
                                                             [FromQuery] int pageSize = 0,
                                                             [FromQuery] int pageIndex = 1,
                                                             [FromQuery] SortType sortType = SortType.Ascending)
        {
            var serviceResponse = await _syllabusService.GetAllSyllabusAdvanceAsync(s => s.Name.Contains(keyword ?? ""), pageSize, pageIndex, sortType);
            return Ok(serviceResponse.Result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSyllabusByIdAsync(int id, int time)
        {
            var serviceResponse = await _syllabusService.GetSyllabusByIdAsync(id, time);
            if (serviceResponse == null)
            {
                return BadRequest();
            }
            return Ok(serviceResponse.Result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSyllabus([FromBody] SyllabusCreateDTO dto)
        {
            var result = await _syllabusCreateValidator.ValidateAsync(dto);
            if (!result.IsValid)
            {
                return BadRequest(result.ToString());
            }
            var serviceResponse = await _syllabusService.CreateSyllabusAsync(dto);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSyllabus(int id, [FromBody] SyllabusUpdateDTO dto)
        {
            if (id != dto.Id)
            {
                return BadRequest("Invalid Id");
            }
            var result = await _syllabusUpdateValidator.ValidateAsync(dto);
            if (!result.IsValid)
            {
                return BadRequest(result.ToString());
            }
            var serviceResponse = await _syllabusService.UpdateSyllabusAsync(dto);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSyllabus(int id)
        {
            var serviceResponse = await _syllabusService.RemoveSyllabusAsync(id);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpGet("{id}/StudentAssigment/{idStudent}/AverageSocre")]
        public async Task<IActionResult> GetAverageOfStudentInSyllabusAsync(int id, int idStudent)
        {
            var serviceResponse = await _syllabusService.GetAverageOfStudentInSyllabusAsync(id, idStudent);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }
        [HttpGet("{id}/StudentAssigment/AverageSocre")]
        public async Task<IActionResult> GetAverageOfAllStudentInSyllabusAsync(int id)
        {
            var serviceResponse = await _syllabusService.GetAverageOfAllStudentInSyllabusAsync(id);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }
    }
}
