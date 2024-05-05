using Application.Commons;
using Application.ViewModels.TrainingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITrainingClassService
    {
        Task<Pagination<TrainingClassViewDTO>> GetClassesAysnc(int pageIndex,
             int pageSize,
             string search,
             DateTime createOnStart,
             DateTime createOnEnd);
        Task CreateClassAsync(TrainingClassCreateDTO createDTO);
        Task UpdateClassInfomationAsync(TrainingClassInfomationUpdateDTO updateDTO);
        Task UpdateClassReviewerAsync(TrainingClassReviewUpdateDTO updateDTO);
        Task UpdateClassStatusAsync(TrainingClassStatusUpdateDTO updateDTO);
        Task<TrainingClassViewDetailDTO> GetTrainingClassDetailAsync(int id);
        Task SoftDeleteClassAsync(int id);
        Task RestoreClassAsync(int id);

    }
}
