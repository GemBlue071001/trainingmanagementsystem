using Application.ViewModels.Student;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Validations.StudentValidators
{
    public class StudentCreateDTOValidator : AbstractValidator<StudentCreateDTO>
    {
        public StudentCreateDTOValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.FullName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty()
                .Matches("^[0-9]*$").WithMessage("Phone number must be a string of numbers.");
            RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now).When(x => x.DateOfBirth.HasValue);
            RuleFor(x => x.Level).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Gender).IsInEnum();
            RuleFor(x => x.TrainingClassId).NotEmpty();
        }
    }
}
