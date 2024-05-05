using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class SyllabusConfiguration : IEntityTypeConfiguration<Syllabus>
    {
        public void Configure(EntityTypeBuilder<Syllabus> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(s => s.Name).IsRequired();
            builder.Property(s => s.Code).IsRequired();

            builder.Property(s => s.AttendeeNumber).IsRequired().HasDefaultValue(0);
            builder.Property(s => s.TechnicalRequirement).IsRequired();
            builder.Property(s => s.CourseObjective).IsRequired();
            builder.Property(s => s.TrainingDeliveryPrinciple).IsRequired();

            builder.Property(s => s.SyllabusLevel).IsRequired();
            builder.Property(s => s.Version).IsRequired();

            builder.Property(s => s.QuizSchema).IsRequired();
            builder.Property(s => s.AssignmentSchema).IsRequired();
            builder.Property(s => s.FinalSchema).IsRequired();
            builder.Property(s => s.FinalTheorySchema).IsRequired();
            builder.Property(s => s.FinalPracticeSchema).IsRequired();
            builder.Property(s => s.GPASchema).IsRequired();

            var jsonString = File.ReadAllText("./SeedData/SyllabusSeedData.json");
            var entities = JsonSerializer.Deserialize<List<Syllabus>>(jsonString);

            builder.HasData(entities);
        }
    }
}
