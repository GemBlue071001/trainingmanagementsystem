using Application.ViewModels.TrainingClasses;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Validations.TrainingClasses
{
    public class TrainingClassValidator : AbstractValidator<TrainingClassCreateDTO>
    {
        public TrainingClassValidator()
        {
            RuleFor(s => s.AttendeeType).IsInEnum();
            RuleFor(s => s.NumberAttendeeActual).LessThan(50).GreaterThan(0);
            RuleFor(s => s.NumberAttendeeAccepted).LessThan(50).GreaterThan(0);
            RuleFor(s => s.NumberAttendeePlanned).LessThan(50).GreaterThan(0);
            RuleFor(s => s.ClassTimeStart).GreaterThan(DateTime.Now);
            RuleFor(s => s.ClassTimeEnd)
                    .GreaterThan(s => s.ClassTimeStart)
                    .WithMessage("Class end time must be greater than class start time");

        }
    }
}
