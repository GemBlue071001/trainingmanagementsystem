using Domain.Entities;
using FluentValidation;

namespace Infrastructures.Validations
{
    public class SyllabusValidator : AbstractValidator<Syllabus>
    {
        public SyllabusValidator()
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
        }
    }
}
