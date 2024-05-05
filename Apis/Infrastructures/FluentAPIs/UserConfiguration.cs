using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Text.Json;

namespace Infrastructures.FluentAPIs
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.FullName).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.PhoneNumber).IsRequired();
            builder.Property(u => u.DateOfBirth).IsRequired(false);
            builder.Property(u => u.Level).IsRequired();
            builder.Property(u => u.Gender).IsRequired();
            builder.Property(u => u.Status).IsRequired().HasDefaultValue(UserStatus.Active);
            builder.Property(u => u.Role).IsRequired().HasDefaultValue(UserRoleType.Trainee);

            builder.HasQueryFilter(u => !u.IsDeleted);

            //var jsonString = File.ReadAllText("./SeedData/UserSeedData.json");
            //var entities = JsonSerializer.Deserialize<List<Syllabus>>(jsonString);

            //builder.HasData(entities);

            builder.HasData(
            new User
            {
                Id = 1,
                CreatedOn = DateTime.Now,
                CreatedByUserId = 1,
                UserName = "user1",
                Password = "password",
                FullName = "User 1",
                Email = "user1@example.com",
                PhoneNumber = "555-555-1212",
                DateOfBirth = new DateTime(1990, 1, 1),
                Level = "Beginner",
                Gender = Gender.Male,
                Status = UserStatus.Active,
                Role = UserRoleType.Student
            },
            new User
            {
                Id = 2,
                CreatedOn = DateTime.Now,
                CreatedByUserId = 1,
                UserName = "user2",
                Password = "password",
                FullName = "User 2",
                Email = "user2@example.com",
                PhoneNumber = "555-555-1213",
                DateOfBirth = new DateTime(1995, 5, 5),
                Level = "Intermediate",
                Gender = Gender.Female,
                Status = UserStatus.Active,
                Role = UserRoleType.Student
            },
            new User
            {
                Id = 3,
                CreatedOn = DateTime.Now,
                CreatedByUserId = 1,
                UserName = "user3",
                Password = "password",
                FullName = "User 3",
                Email = "user3@example.com",
                PhoneNumber = "555-555-1214",
                DateOfBirth = new DateTime(2000, 10, 10),
                Level = "Advanced",
                Gender = Gender.Male,
                Status = UserStatus.Active,
                Role = UserRoleType.Student
            },
            new User
            {
                Id = 4,
                CreatedOn = DateTime.Now,
                CreatedByUserId = 1,
                UserName = "user4",
                Password = "password",
                FullName = "User 4",
                Email = "user4@example.com",
                PhoneNumber = "555-555-1215",
                DateOfBirth = new DateTime(1992, 2, 2),
                Level = "Intermediate",
                Gender = Gender.Female,
                Status = UserStatus.Active,
                Role = UserRoleType.ClassAdmin
            },
            new User
            {
                Id = 5,
                CreatedOn = DateTime.Now,
                CreatedByUserId = 1,
                UserName = "user5",
                Password = "password",
                FullName = "User 5",
                Email = "user5@example.com",
                PhoneNumber = "555-555-1216",
                DateOfBirth = new DateTime(1999, 7, 7),
                Level = "Beginner",
                Gender = Gender.Male,
                Status = UserStatus.Active,
                Role = UserRoleType.Trainer
            }
        );
            builder.HasDiscriminator<string>("Discriminator").HasValue<User>("User").HasValue<Student>("Student");

        }
    }
}
