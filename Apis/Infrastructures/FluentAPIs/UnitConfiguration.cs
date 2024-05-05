using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Day).IsRequired();
            builder.Property(x => x.SortOrder).IsRequired();

            builder.HasOne(u => u.Syllabus)
                   .WithMany(s => s.Units)
                   .HasForeignKey(u => u.SyllabusId);

            var jsonString = File.ReadAllText("./SeedData/UnitSeedData.json");
            var entities = JsonSerializer.Deserialize<List<Unit>>(jsonString);

            builder.HasData(entities);
        }
    }
}