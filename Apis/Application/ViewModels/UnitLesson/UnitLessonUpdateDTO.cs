﻿using Application.ViewModels.TrainingMaterial;
using Domain.Entities;
using Domain.Enums;

namespace Application.ViewModels.UnitLesson
{
    public class UnitLessonUpdateDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public LessonType LessonType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public OutputStandardUpdateDTO OutputStandard { get; set; }
        public ICollection<TrainingMaterialUpdateDTO> TrainingMaterial { get; set; }
    }
}
