using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructures.FluentAPIs
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoleType)
                .IsRequired();
            builder.Property(x => x.SyllabusAccessPermission)
                .IsRequired();
            builder.Property(x => x.TrainingProgramAccessPermission)
                .IsRequired();
            builder.Property(x => x.ClassAccessPermission)
                .IsRequired();
            builder.Property(x => x.LearningMaterialAccessPermission)
                .IsRequired();
            builder.Property(x => x.UserAccessPermission)
                .IsRequired();
        }
    }
}
