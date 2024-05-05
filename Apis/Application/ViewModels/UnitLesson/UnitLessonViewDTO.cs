using Application.ViewModels.TrainingMaterial;
using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.UnitLesson
{
    public class UnitLessonViewDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public LessonType LessonType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public OutputStandardViewDTO OutputStandard { get; set; }
        public ICollection<TrainingMaterialViewDTO> TrainingMaterial { get; set; }
    }
}
