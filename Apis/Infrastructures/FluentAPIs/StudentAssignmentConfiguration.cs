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
    public class StudentAssignmentConfiguration : IEntityTypeConfiguration<StudentAssignment>
    {
        public void Configure(EntityTypeBuilder<StudentAssignment> builder)
        {
            // Configure base class properties
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.StudentId, x.AssignmentId});

            // Configure Assignment foreign key
            builder.HasOne(sa => sa.Assignment)
                .WithMany(a => a.StudentAssignments)
                .HasForeignKey(sa => sa.AssignmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Student foreign key
            builder.HasOne(sa => sa.Student)
                .WithMany(s => s.StudentAssignments)
                .HasForeignKey(sa => sa.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Score property
            builder.Property(sa => sa.Score)
                .HasColumnType("decimal(4,2)")
                .HasPrecision(4, 2)
                .IsRequired(false);

            // Configure TimeSubmit property
            builder.Property(sa => sa.TimeSubmit)
                .HasColumnType("datetime2")
                .IsRequired(false);

            // Configure IsGraded property
            builder.Property(sa => sa.IsGraded)
                .IsRequired(false);

            // Configure Comment property
            builder.Property(sa => sa.Comment)
                .IsRequired(false)
                .HasMaxLength(500);

            // Configure StudentFileLink property
            builder.Property(sa => sa.AssignmentFileLink)
                .IsRequired(false);

            // Configure Status property
            builder.Property(sa => sa.Status)
                .IsRequired();

            builder.HasQueryFilter(s => !s.IsDeleted);

            var jsonString = File.ReadAllText("./SeedData/StudentAssignmentSeedData.json");
            var entities = JsonSerializer.Deserialize<List<StudentAssignment>>(jsonString);

            builder.HasData(entities);
        }
    }

}
