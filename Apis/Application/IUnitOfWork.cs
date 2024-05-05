using Application.Repositories;

namespace Application
{
    public interface IUnitOfWork
    {
        ISyllabusRepository Syllabuses { get; }
        IUnitRepository Units { get; }
        IUnitLessonRepository Lessons { get; }
        ITrainingProgramRepository TrainingPrograms { get; }
        ITrainingMaterialRepository TrainingMaterials { get; }
        ITrainingClassRepository TrainingClass { get; }
        IOutputStandardRepository OutputStandards { get; }
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }
        IStudentRepository Students { get; }
        IAssignmentRepository Assignments { get; }
        IStudentAssignmentRepository StudentAssignments { get; }

        IProgramSyllabusRepository ProgramSyllabus { get; }
        Task<int> SaveChangesAsync();
    }
}
