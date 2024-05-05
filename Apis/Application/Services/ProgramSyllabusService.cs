using Application.Interfaces;
using Application.Utils;
using AutoMapper;
using Domain.Entities;
using FluentValidation;

namespace Application.Services
{
    public class ProgramSyllabusService : IProgramSyllabusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly IValidator<ProgramSyllabus> _validator;
        private readonly ServiceResponse _serviceResponse;
        public ProgramSyllabusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _serviceResponse = new ServiceResponse();
        }
        public async Task<ServiceResponse> DeleteProgramSyllabusAsync(int syllabusId, int trainingProgramId)
        {
            var oldprogramSyllabus = await _unitOfWork.ProgramSyllabus.GetAsync(x => x.SyllabusId == syllabusId 
                                                                                && x.TrainingProgramId == trainingProgramId, true);
            if (oldprogramSyllabus == null || oldprogramSyllabus.IsDeleted == true)
            {
                return _serviceResponse.Fail("Program Syllabus not found");
            }
            await _unitOfWork.ProgramSyllabus.RemoveAsync(oldprogramSyllabus);
            await _unitOfWork.SaveChangesAsync();   
            return _serviceResponse.Success();
        }

        public async Task<ServiceResponse> GetProgramSyllabusByIdAsync(int syllabusId, int trainingProgramId)
        {
            var programSyllabus = await _unitOfWork.ProgramSyllabus.GetAsync(x => x.SyllabusId == syllabusId && x.TrainingProgramId == trainingProgramId 
                                                                                && x.IsDeleted == false, true);
            if (programSyllabus == null)
            {
                return _serviceResponse.Fail("Program Syllabus not found");
            }
            return _serviceResponse.Success(programSyllabus);
        }
    }
}
