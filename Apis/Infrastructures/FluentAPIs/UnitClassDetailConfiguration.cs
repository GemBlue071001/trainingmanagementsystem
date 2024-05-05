using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructures.FluentAPIs
{
    public class UnitClassDetailConfiguration : IEntityTypeConfiguration<UnitClassDetail>
    {
        public void Configure(EntityTypeBuilder<UnitClassDetail> builder)
        {
            builder.HasKey(x => new { x.ClassId, x.UnitId });
            builder.Ignore(x => x.Id);

            builder.Property(x=> x.StartTime).IsRequired();
            builder.Property(x=> x.EndTime).IsRequired();

            builder.HasOne(x => x.TrainingClass)
                .WithMany(c => c.UnitClassDetails)
                .HasForeignKey(x => x.ClassId);

            builder.HasOne(ucd => ucd.Unit)
                .WithMany(u => u.UnitClassDetails)
                .HasForeignKey(ucd => ucd.UnitId);

            builder.HasOne(ucd => ucd.Trainer)
                .WithMany(u => u.UnitClassDetails)
                .HasForeignKey(ucd => ucd.TrainerId);

            builder.HasOne(ucd => ucd.Location)
                .WithMany(u => u.UnitClassDetailLocations)
                .HasForeignKey(ucd => ucd.LocationId);

            var jsonString = File.ReadAllText("./SeedData/UnitClassDetailSeedData.json");
            var entities = JsonSerializer.Deserialize<List<UnitClassDetail>>(jsonString);

            builder.HasData(entities);
        }
    }
}
