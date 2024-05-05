using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructures.FluentAPIs
{
    public class UnitClassLocationConfiguration : IEntityTypeConfiguration<UnitClassLocation>
    {
        public void Configure(EntityTypeBuilder<UnitClassLocation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BuildingLocation).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Room).IsRequired();

            var jsonString = File.ReadAllText("./SeedData/UnitClassLocationSeedData.json");
            var entities = JsonSerializer.Deserialize<List<UnitClassLocation>>(jsonString);

            builder.HasData(entities);
        }
    }
}
