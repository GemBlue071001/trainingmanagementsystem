using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class OutputStandardConfiguration : IEntityTypeConfiguration<OutputStandard>
    {
        public void Configure(EntityTypeBuilder<OutputStandard> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(o => o.Code).IsRequired();
            builder.Property(o => o.Title).IsRequired();
            builder.Property(o => o.Description).IsRequired();

            var jsonString = File.ReadAllText("./SeedData/OutputStandardSeedData.json");
            var entities = JsonSerializer.Deserialize<List<OutputStandard>>(jsonString);

            builder.HasData(entities);

        }
    }
}
