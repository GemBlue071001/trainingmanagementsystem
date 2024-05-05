using Domain.Entities;
using Infrastructures.FluentAPIs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructures
{
    public class AppDbContext : DbContext
    {
        public DbSet<Syllabus> Syllabuses { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitLesson> UnitLessons { get; set; }
        public DbSet<OutputStandard> OutputStandards { get; set; }
        public DbSet<TrainingMaterial> TrainingMaterials { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<ProgramSyllabus> ProgramSyllabuses { get; set; }
        public DbSet<TrainingClass> TrainingClasses { get; set; }
        public DbSet<FSU> FSUs { get; set; }
        public DbSet<UnitClassDetail> UnitClassDetails { get; set; }
        public DbSet<UnitClassLocation> UnitClassLocations { get; set; }
        public DbSet<ClassAdmin> ClassAdmins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SyllabusConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new UnitLessonConfiguration());
            modelBuilder.ApplyConfiguration(new OutputStandardConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingProgramConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramSyllabusConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingClassConfiguration());
            modelBuilder.ApplyConfiguration(new FSUConfiguration());
            modelBuilder.ApplyConfiguration(new UnitClassDetailConfiguration());
            modelBuilder.ApplyConfiguration(new UnitClassLocationConfiguration());
            modelBuilder.ApplyConfiguration(new ClassAdminConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new AssignmentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentAssignmentConfiguration());
        }
    }
}