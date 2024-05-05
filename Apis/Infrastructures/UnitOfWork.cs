using Application;
using Application.Interfaces;
using Application.Repositories;
using Infrastructures.Repositories;

namespace Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context, ICurrentTime currentTime, IClaimsService claimsService)
        {
            _context = context;
            Syllabuses = new SyllabusRepository(context, currentTime, claimsService);
            Units = new UnitRepository(context, currentTime, claimsService);
            Lessons = new UnitLessonRepository(context, currentTime, claimsService);
            TrainingPrograms = new TrainingProgramRepository(context, currentTime, claimsService);
            TrainingMaterials = new TrainingMaterialRepository(context, currentTime, claimsService);
            TrainingClass = new TrainingClassRepository(context, currentTime, claimsService);
            Users = new UserRepository(context, currentTime, claimsService);
            UserRoles = new UserRoleRepository(context, currentTime, claimsService);
            Students = new StudentRepository(context, currentTime, claimsService);
            Assignments = new AssignmentRepository(context, currentTime, claimsService);
            StudentAssignments = new StudentAssignmentRepository(context, currentTime, claimsService);
            ProgramSyllabus = new ProgramSyllabusRepository(context, currentTime, claimsService);
        }

        public ISyllabusRepository Syllabuses { get; }
        public IUnitRepository Units { get; }
        public IUnitLessonRepository Lessons { get; }
        public ITrainingProgramRepository TrainingPrograms { get; }
        public ITrainingMaterialRepository TrainingMaterials { get; }
        public ITrainingClassRepository TrainingClass { get; }
        public IOutputStandardRepository OutputStandards { get; }
        public IUserRepository Users { get; }
        public IUserRoleRepository UserRoles { get; }

        public IStudentRepository Students { get; }

        public IAssignmentRepository Assignments { get; }

        public IStudentAssignmentRepository StudentAssignments { get; }

        public IProgramSyllabusRepository ProgramSyllabus { get; }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
