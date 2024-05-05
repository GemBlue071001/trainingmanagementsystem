using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class UnitLessonConfiguration : IEntityTypeConfiguration<UnitLesson>
    {
        public void Configure(EntityTypeBuilder<UnitLesson> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.LessonType).IsRequired();
            builder.Property(x => x.DeliveryType).IsRequired();

            builder.HasOne(ul => ul.OutputStandard)
                   .WithMany(os => os.UnitLessons)
                   .HasForeignKey(ul => ul.OutputStandardId);
            builder.HasOne(ul => ul.Unit)
                   .WithMany(u => u.UnitLessons)
                   .HasForeignKey(ul => ul.UnitId);

            var jsonString = File.ReadAllText("./SeedData/UnitLessonSeedData.json");
            var entities = JsonSerializer.Deserialize<List<UnitLesson>>(jsonString);

            builder.HasData(entities);

        }
    }
}
