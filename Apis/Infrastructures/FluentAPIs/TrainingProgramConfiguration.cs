using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class TrainingProgramConfiguration : IEntityTypeConfiguration<TrainingProgram>
    {
        public void Configure(EntityTypeBuilder<TrainingProgram> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.ParentId).IsRequired(false);
            builder.Property(t => t.Status)
                   .IsRequired()
                   .HasDefaultValue(TrainingProgramStatus.Active);

            var jsonString = File.ReadAllText("./SeedData/TrainingProgramSeedData.json");
            var entities = JsonSerializer.Deserialize<List<TrainingProgram>>(jsonString);

            builder.HasData(entities);
        }
    }
}
