using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IStudentAssignmentRepository : IGenericRepository<StudentAssignment>
    {
        Task<ICollection<StudentAssignment>> GetStudentAssignmentByIdStudentAsync(Expression<Func<StudentAssignment, bool>>? filter = null
                                                  , bool tracked = true);
    }
}
