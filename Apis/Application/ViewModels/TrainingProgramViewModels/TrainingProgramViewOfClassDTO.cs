using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.TrainingProgramViewModels
{
    public class TrainingProgramViewOfClassDTO
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public TrainingProgramStatus Status { get; set; }
       
        public ICollection<ProgramSyllabusDTO> ProgramSyllabuses { get; set; }
    }
}
