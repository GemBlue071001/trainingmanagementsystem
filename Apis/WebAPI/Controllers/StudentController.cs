using Application.Interfaces;
using Application.Services;
using Application.ViewModels.Student;
using Application.ViewModels.TrainingProgramViewModels;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IValidator<StudentCreateDTO> _createValidator;
        private readonly IValidator<StudentUpdateDTO> _updateValidator;

        public StudentController(IStudentService studentService, IValidator<StudentCreateDTO> createValidator, IValidator<StudentUpdateDTO> updateValidator) 
        {
            _studentService = studentService;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsInClass(int classId,
            int pageIndex = 1,
            int pageSize = 3)
        {
            if(pageIndex <= 0 || pageSize <= 0)
            {
                return BadRequest("Your Pagination is not valid");
            }
            var list = await _studentService.GetAllStudentInClass(classId, pageSize, pageIndex);
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var serviceResponse = await _studentService.GetStudentById(id);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return NotFound(serviceResponse.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] StudentCreateDTO studentCreateDTO)
        {
            //TODO
            //Validate studentCreateDTO
            var result = await _createValidator.ValidateAsync(studentCreateDTO);
            if (!result.IsValid) return BadRequest(result.ToString());

            var serviceResponse = await _studentService.CreateStudent(studentCreateDTO);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return BadRequest(serviceResponse.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent([FromBody] StudentUpdateDTO studentUpdateDTO)
        {
            //TODO
            //Validate studentCreateDTO
            var result = await _updateValidator.ValidateAsync(studentUpdateDTO);
            if (!result.IsValid) return BadRequest(result.ToString());

            var serviceResponse = await _studentService.UpdateStudent(studentUpdateDTO);
            if (serviceResponse.IsSuccess)
            {
                return Ok(serviceResponse.Result);
            }
            return NotFound(serviceResponse.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            //TODO
            //Validate studentCreateDTO
            var serviceResponse = await _studentService.SoftDeleteStudent(id);
            if (serviceResponse.IsSuccess)
            {
                return Ok();
            }
            return NotFound(serviceResponse.Message);
        }
    }
}
