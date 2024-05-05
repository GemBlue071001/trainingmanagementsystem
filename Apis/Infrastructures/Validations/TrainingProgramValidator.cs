using Domain.Entities;
using FluentValidation;

namespace Infrastructures.Validations
{
    public class TrainingProgramValidator : AbstractValidator<TrainingProgram>
    {
        public TrainingProgramValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
