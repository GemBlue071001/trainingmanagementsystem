using Application.Utils;
using Application.ViewModels.TrainingProgramViewModels;

namespace Application.Interfaces
{
    public interface IProgramSyllabusService
    {
        Task<ServiceResponse> GetProgramSyllabusByIdAsync(int syllabusId, int trainingProgramId);
        Task<ServiceResponse> DeleteProgramSyllabusAsync(int syllabusId, int trainingProgramId);
    }
}
