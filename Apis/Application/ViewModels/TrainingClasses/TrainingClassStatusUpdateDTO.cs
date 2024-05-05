using Domain.Enums;
namespace Application.ViewModels.TrainingClasses
{
    public class TrainingClassStatusUpdateDTO
    {
        public ClassStatus Status { get; set; }
        public int TrainingClassId { get; set; }
    }
}
