using Application.ViewModels.Student;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Validations.StudentValidators
{
    public class StudentUpdateDTOValidator : AbstractValidator<StudentUpdateDTO>
    {
        public StudentUpdateDTOValidator()
        {
            RuleFor(dto => dto.Id).NotEmpty();
            RuleFor(dto => dto.UserName).NotEmpty();
            RuleFor(dto => dto.FullName).NotEmpty();
            RuleFor(dto => dto.Email).NotEmpty().EmailAddress();
            RuleFor(dto => dto.PhoneNumber).NotEmpty()
                .Matches("^[0-9]*$").WithMessage("Phone number must be a string of numbers.");
            RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now).When(x => x.DateOfBirth.HasValue);
            RuleFor(dto => dto.Level).NotEmpty().MaximumLength(50);
            RuleFor(dto => dto.Gender).IsInEnum();
            RuleFor(dto => dto.Status).IsInEnum();
        }
    }

}
