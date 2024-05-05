using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class ProgramSyllabusConfiguration : IEntityTypeConfiguration<ProgramSyllabus>
    {
        public void Configure(EntityTypeBuilder<ProgramSyllabus> builder)
        {
            builder.HasKey(x => new { x.SyllabusId, x.TrainingProgramId });
            builder.Ignore(x => x.Id);

            builder.HasOne(ps => ps.Syllabus)
                   .WithMany(s => s.ProgramSyllabuses)
                   .HasForeignKey(ps => ps.SyllabusId);
            builder.HasOne(ps => ps.TrainingProgram)
                   .WithMany(s => s.ProgramSyllabuses)
                   .HasForeignKey(ps => ps.TrainingProgramId);

            var jsonString = File.ReadAllText("./SeedData/ProgramSyllabusSeedData.json");
            var entities = JsonSerializer.Deserialize<List<ProgramSyllabus>>(jsonString);
            builder.HasData(entities);
        }
    }
}
