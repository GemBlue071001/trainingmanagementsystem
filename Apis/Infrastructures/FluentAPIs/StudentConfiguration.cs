using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Configure base class properties
            builder.HasBaseType<User>();

            builder.Property(s => s.Role).IsRequired().HasDefaultValue(UserRoleType.Student);
            // Configure TrainingClass foreign key
            builder.HasOne(s => s.TrainingClass)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.TrainingClassId)
                .OnDelete(DeleteBehavior.NoAction);

           

            var jsonString = File.ReadAllText("./SeedData/StudentSeedData.json");
            var entities = JsonSerializer.Deserialize<List<Student>>(jsonString);

            builder.HasData(entities);
        }
    }
}
