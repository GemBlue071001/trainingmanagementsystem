using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;

namespace Infrastructures.Repositories
{
    public class ProgramSyllabusRepository : GenericRepository<ProgramSyllabus>, IProgramSyllabusRepository
    {
        public ProgramSyllabusRepository(AppDbContext applicationDbContext, ICurrentTime timeService, IClaimsService claimsService) : base(applicationDbContext, timeService, claimsService)
        {
        }
    }
}
