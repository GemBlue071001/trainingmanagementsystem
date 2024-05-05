using Application;
using Application.Interfaces;
using Application.Services;
using Application.ViewModels.Syllabus;
using FluentValidation;
using Domain.Entities;
using Infrastructures.Mapper;
using Infrastructures.Validations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructures
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, string databaseConnection)
        {
            services.AddScoped<ISyllabusService, SyllabusService>();
            services.AddScoped<ITrainingProgramService, TrainingProgramService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddSingleton<ICurrentTime, CurrentTime>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IStudentAssignmentService, StudentAssignmentService>();

            services.AddSingleton<ICurrentTime, CurrentTime>();
            services.AddScoped<IProgramSyllabusService, ProgramSyllabusService>();

            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(databaseConnection));
            //services.AddAutoMapper(typeof(MapperConfigurationsProfile));

            services.AddAutoMapper(typeof(MapperConfigurationsProfile).Assembly);

            services.AddScoped<IValidator<SyllabusCreateDTO>, SyllabusCreateValidator>();
            services.AddScoped<IValidator<SyllabusUpdateDTO>, SyllabusUpdateValidator>();

            return services;
        }

    }
}
