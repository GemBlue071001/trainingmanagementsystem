using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class TrainingClassConfiguration : IEntityTypeConfiguration<TrainingClass>
    {
        public void Configure(EntityTypeBuilder<TrainingClass> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(tc=>tc.ClassName).IsRequired();
            builder.Property(tc=>tc.ClassCode).IsRequired();
            builder.Property(tc=>tc.ClassLocation).IsRequired();
            builder.Property(tc=>tc.ClassTimeStart).IsRequired();
            builder.Property(tc=>tc.ClassTimeEnd).IsRequired();
            builder.Property(tc=>tc.Status).HasDefaultValue(ClassStatus.Planning);

            builder.Property(tc => tc.ModifiedOn).IsRequired(false);
            builder.Property(tc => tc.ReviewedOn).IsRequired(false);
            builder.Property(tc => tc.ApprovedOn).IsRequired(false);

            builder.Property(tc => tc.CreatedByUserId).IsRequired(false);
            builder.Property(tc => tc.ModifiedByUserId).IsRequired(false);
            builder.Property(tc => tc.UserReviewedId).IsRequired(false);
            builder.Property(tc => tc.UserApprovedId).IsRequired(false);


            builder.Property(tc => tc.AttendeeType).IsRequired();   
            builder.Property(tc => tc.NumberAttendeePlanned).IsRequired();
            builder.Property(tc => tc.NumberAttendeeAccepted).IsRequired();
            builder.Property(tc => tc.NumberAttendeeActual).IsRequired();

            builder.HasOne(tc => tc.FSU)
                .WithMany(fsu => fsu.TrainingClasses)
                .HasForeignKey(tc => tc.FSUId);

            builder.HasOne(c => c.TrainingProgram)
                   .WithOne(t => t.TrainingClass)
                   .HasForeignKey<TrainingClass>(c => c.TrainingProgramId);

            var jsonString = File.ReadAllText("./SeedData/TrainingClassSeedData.json");
            var entities = JsonSerializer.Deserialize<List<TrainingClass>>(jsonString);

            builder.HasData(entities);
        }
    }
}
