using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class ClassAdminConfiguration : IEntityTypeConfiguration<ClassAdmin>
    {
        public void Configure(EntityTypeBuilder<ClassAdmin> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.UserId, x.TrainingClassId });

            builder.HasOne(ps => ps.User)
                   .WithMany(s => s.ClassAdmins)
                   .HasForeignKey(ps => ps.UserId);

            builder.HasOne(ps => ps.TrainingClass)
                   .WithMany(s => s.Admins)
                   .HasForeignKey(ps => ps.TrainingClassId);

            var jsonString = File.ReadAllText("./SeedData/ClassAdminSeedData.json");
            var entities = JsonSerializer.Deserialize<List<ClassAdmin>>(jsonString);

            builder.HasData(entities);
        }
    }
}