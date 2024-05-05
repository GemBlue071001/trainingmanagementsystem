using Application.Services;
using Domain.Entities;
using Domain.Enums;
using Microsoft.Exchange.WebServices.Data;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface ISyllabusRepository : IGenericRepository<Syllabus>
    {
        Task<Syllabus> GetSyllabusRelationUnitAsync(int id);
        Task<Syllabus> GetSyllabusRelationAssignmentAsync(int id);
        public Task<Syllabus> GetSyllabusByIdAsync(Expression<Func<Syllabus, bool>>? filter = null, bool tracked = true);
    }
}
