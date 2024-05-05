using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class TrainingMaterialConfiguration : IEntityTypeConfiguration<TrainingMaterial>
    {
        public void Configure(EntityTypeBuilder<TrainingMaterial> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.FileName).IsRequired();
            builder.Property(t => t.FileLink).IsRequired();

            builder.HasOne(t => t.UnitLesson)
                   .WithMany(ul => ul.TrainingMaterials)
                   .HasForeignKey(t => t.UnitLessonId);

            var jsonString = File.ReadAllText("./SeedData/TrainingMaterialSeedData.json");
            var entities = JsonSerializer.Deserialize<List<TrainingMaterial>>(jsonString);

            builder.HasData(entities);
        }
    }
}
