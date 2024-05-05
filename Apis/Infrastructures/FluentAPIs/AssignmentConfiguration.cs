using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            // Configure base class properties
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Name).IsRequired(); 
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Type).IsRequired().HasDefaultValue(AssignmentType.Quiz);
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();

            // Configure TrainingClass foreign key
            builder.HasOne(a => a.TrainingClass)
                .WithMany(t => t.Assignments)
                .HasForeignKey(a => a.TrainingClassId);

            // Configure Syllabus foreign key
            builder.HasOne(a => a.Syllabus)
                .WithMany(s => s.Assignments)
                .HasForeignKey(a => a.SyllabusId);

            builder.HasQueryFilter(a => !a.IsDeleted);

            var jsonString = File.ReadAllText("./SeedData/AssignmentSeedData.json");
            var entities = JsonSerializer.Deserialize<List<Assignment>>(jsonString);

            builder.HasData(entities);

        }
    }

}
