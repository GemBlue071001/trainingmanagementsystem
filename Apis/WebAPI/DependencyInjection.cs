using Application;
using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using FluentValidation;
using Infrastructures.Validations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Services;
using WebAPI.Middlewares;
using Application.ViewModels.TrainingClasses;
using Infrastructures.Validations.TrainingClasses;
using Application.ViewModels.Student;
using Infrastructures.Validations.StudentValidators;

namespace WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPIService(this IServiceCollection services, AppConfiguration appConfig)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddSingleton<GlobalExceptionMiddleware>();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appConfig.SecretKey))
                };
            });
            services.AddAuthorization();
            services.AddHttpContextAccessor();
            services.AddSingleton<IClaimsService, ClaimsService>();
            services.AddScoped<IValidator<TrainingProgram>, TrainingProgramValidator>();
            services.AddScoped<IValidator<TrainingClassCreateDTO>, TrainingClassValidator>();
            services.AddScoped<ITrainingClassService, TrainingClassService>();

            //regis validator
            services.AddScoped<IValidator<StudentCreateDTO>, StudentCreateDTOValidator>();
            services.AddScoped<IValidator<StudentUpdateDTO>, StudentUpdateDTOValidator>();

            return services;
        }
    }

}
