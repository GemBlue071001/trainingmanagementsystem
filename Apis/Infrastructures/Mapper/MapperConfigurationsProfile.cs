
using Application.ViewModels;
using Application.ViewModels.TrainingProgramViewModels;
using Application.ViewModels.ClassAdminDTO;
using Application.ViewModels.FSUDTO;
using Application.ViewModels.Syllabus;
using Application.ViewModels.FSUDTO;
using Application.ViewModels.TrainingClasses;
using Application.ViewModels.TrainingMaterial;
using Application.ViewModels.TrainingProgramViewModels;
using Application.ViewModels.TrainingProgramViewModels;
using Application.ViewModels.UnitClassDetailViewModel;
using AutoMapper;
using Domain.Entities;
using Application.ViewModels.FSUDTO;
using Application.ViewModels.UserAdmin;
using Application.ViewModels.UserViewModels;
using AutoMapper;
using Domain.Entities;
using Application.ViewModels.UnitClassLocationDTO;
using Application.ViewModels.Student;
using Application.ViewModels.UnitLesson;

namespace Infrastructures.Mapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            #region Syllabus
            CreateMap<Syllabus, SyllabusViewDTO>().ReverseMap();
            CreateMap<Syllabus, ClassProgramSylabusViewDTO>().ReverseMap();
            CreateMap<SyllabusCreateDTO, Syllabus>().ReverseMap();
            CreateMap<SyllabusUpdateDTO, Syllabus>().ReverseMap();

            #endregion
            #region Unit
            CreateMap<Syllabus, SyllabusViewDTO>()
            .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Units.Select(u => u.UnitLessons.Sum(x => x.Duration))
                             .Sum()));
            CreateMap<TrainingProgram, TrainingProgramViewDTO>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramCreateDTO>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramUpdateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusCreateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusUpdateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusDTO>().ReverseMap();

            CreateMap<Unit, UnitViewDTO>().ReverseMap();
            CreateMap<UnitCreateDTO, Unit>().ReverseMap();
            CreateMap<UnitLessonCreateDTO, Unit>().ReverseMap();

            CreateMap<UnitUpdateDTO, Unit>().ReverseMap();
            CreateMap<UnitLessonUpdateDTO, Unit>().ReverseMap();
            #endregion
            #region UnitLesson
            CreateMap<UnitLesson, UnitLessonViewDTO>().ReverseMap();
            CreateMap<UnitLessonCreateDTO, UnitLesson>().ReverseMap();
            CreateMap<UnitLessonUpdateDTO, UnitLesson>().ReverseMap();

            #endregion
            #region TrainingMaterial
            CreateMap<TrainingMaterial, TrainingMaterialViewDTO>().ReverseMap();
            CreateMap<TrainingMaterialCreateDTO, TrainingMaterial>().ReverseMap();
            CreateMap<TrainingMaterialUpdateDTO, TrainingMaterial>().ReverseMap();

            #endregion
            #region OutputStandard
            CreateMap<OutputStandard, OutputStandardViewDTO>().ReverseMap();
            CreateMap<OutputStandardCreateDTO, OutputStandard>().ReverseMap();
            CreateMap<OutputStandardUpdateDTO, OutputStandard>().ReverseMap();
            CreateMap<Syllabus, SyllabusViewDTO>();
            #region Syllabus
            CreateMap<Syllabus, SyllabusViewDto>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Units.Select(u => u.UnitLessons.Sum(x => x.Duration))
                                                                                     .Sum()));
            CreateMap<Unit, UnitViewDTO>().ReverseMap();
            #endregion

             /*.ForMember(dest => dest.OutputStandards, opt => opt.MapFrom(src => src.Units.Select(u => u.UnitLessons.Select(x => x.OutputStandard)).ToList()))*/;
                                                                                     //.Sum()));
            CreateMap<Unit, UnitViewDTO>().ReverseMap();
            CreateMap<UnitLesson, UnitLessonViewDTO>().ReverseMap();
            CreateMap<OutputStandard, OutputStandardViewDTO>().ReverseMap();
            CreateMap<TrainingMaterial, TrainingMaterialViewDTO>().ReverseMap();
            #endregion

            #region User
            CreateMap<User, UserListViewDTO>().ReverseMap();
            CreateMap<User, UserViewDTO>().ReverseMap();
            #endregion

            #region Training program
            CreateMap<TrainingProgram, TrainingProgramViewDTO>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramViewOfClassDTO>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramCreateDTO>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramUpdateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusCreateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusUpdateDTO>().ReverseMap();
            CreateMap<ProgramSyllabus, ProgramSyllabusDTO>().ReverseMap();

            CreateMap<Unit, UnitViewDTO>().ReverseMap();
            CreateMap<UnitLesson, UnitLessonViewDTO>().ReverseMap();
            CreateMap<OutputStandard, OutputStandardViewDTO>().ReverseMap();
            CreateMap<TrainingMaterial, TrainingMaterialViewDTO>().ReverseMap();


            /*.ForMember(dest => dest.OutputStandards, opt => opt.MapFrom(src => src.Units.Select(u => u.UnitLessons.Select(x => x.OutputStandard)).ToList()))*/
            ;
            CreateMap<TrainingClass, TrainingClassViewDTO>().ReverseMap();
            #endregion

            #region Training class
            CreateMap<TrainingClass, TrainingClassCreateDTO>().ReverseMap();
            
            CreateMap<ClassAdmin, ClassAdminCreateDTO>().ReverseMap();
            CreateMap<UnitClassDetail, UnitClassDetailCreateDTO>().ReverseMap();
            CreateMap<TrainingClassViewDetailDTO, TrainingClass>().ReverseMap();
            CreateMap<TrainingClassViewDTO, TrainingClass>().ReverseMap();
            CreateMap<FSUViewDTO, FSU>().ReverseMap();
            CreateMap<ClassAdminViewDTO, ClassAdmin>().ReverseMap();
            CreateMap<AdminViewDTO, User>().ReverseMap();
            CreateMap<UnitClassDetailViewDTO, UnitClassDetail>().ReverseMap();
            CreateMap<UnitClassLocationViewDTO, UnitClassLocation>().ReverseMap();

            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<StudentCreateDTO, Student>().ReverseMap();
            CreateMap<StudentUpdateDTO, Student>().ReverseMap()
                .ForMember(dest => dest.DateOfBirth, opt => opt.Condition(src => src.DateOfBirth != DateTime.MinValue));
            #endregion

        }
    }
}