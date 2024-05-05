using Application.ViewModels.Syllabus;
using FluentValidation;

namespace Infrastructures.Validations
{
    public class SyllabusCreateValidator : AbstractValidator<SyllabusCreateDTO>
    {
        public SyllabusCreateValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(s => s.AttendeeNumber).NotEmpty()
                                           .WithMessage("AttendeeNumber is required");
            RuleFor(s => s.SyllabusLevel).NotEmpty()
                                            .WithMessage("SyllabusLevel is required");
            RuleFor(s => s.TrainingDeliveryPrinciple).NotEmpty()
                                           .WithMessage("TrainingDeliveryPrinciple is required");
            RuleFor(s => s.TechnicalRequirement).NotEmpty()
                                           .WithMessage("TechnicalRequirement is required");
            RuleFor(s => s.CourseObjective).NotEmpty()
                                           .WithMessage("CourseObjective is required");

            RuleFor(s => s.Units).NotEmpty().WithMessage("Units are required")
                       .Must(units => units.Select(u => u.Name).Distinct().Count() == units.Count)
                       .WithMessage("Units must have unique names");

            RuleForEach(s => s.Units).ChildRules(unit =>
            {
                unit.RuleFor(u => u.UnitLessons).NotEmpty().WithMessage("UnitLessons are required for each Unit")
                    .Must(unitLessons => unitLessons.Select(ul => ul.Name).Distinct().Count() == unitLessons.Count)
                    .WithMessage("UnitLessons for each Unit must have unique names");
            });
     
            RuleForEach(s => s.Units).ChildRules(unit =>
            {
                unit.RuleForEach(u => u.UnitLessons).ChildRules(ul =>
                {
                    ul.RuleFor(ul => ul.TrainingMaterial).NotEmpty().WithMessage("UnitLessons are required for each Unit")
                   .Must(trainingmaterials => trainingmaterials.Select(ul => ul.FileName).Distinct().Count() == trainingmaterials.Count)
                   .WithMessage("Training material names must be unique");
                });
  
            });
        }
    }
}
