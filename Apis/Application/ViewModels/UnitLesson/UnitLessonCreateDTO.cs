using Application.ViewModels.TrainingMaterial;
using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.UnitLesson
{
    public class UnitLessonCreateDTO
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public LessonType LessonType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public OutputStandardCreateDTO OutputStandard { get; set; }
        public ICollection<TrainingMaterialCreateDTO> TrainingMaterial { get; set; }
    }
}
