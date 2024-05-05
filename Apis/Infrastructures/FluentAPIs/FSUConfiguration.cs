using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Text.Json;


namespace Infrastructures.FluentAPIs
{
    public class FSUConfiguration : IEntityTypeConfiguration<FSU>
    {
        public void Configure(EntityTypeBuilder<FSU> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired();

            var jsonString = File.ReadAllText("./SeedData/FSUSeedData.json");
            var entities = JsonSerializer.Deserialize<List<FSU>>(jsonString);

            builder.HasData(entities);
        }
    }
}
