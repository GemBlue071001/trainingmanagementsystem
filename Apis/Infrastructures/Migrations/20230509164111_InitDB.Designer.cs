
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace Infrastructures.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230509164111_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SyllabusId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingClassId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("SyllabusId");

                    b.HasIndex("TrainingClassId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Domain.Entities.ClassAdmin", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingClassId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "TrainingClassId");

                    b.HasIndex("TrainingClassId");

                    b.ToTable("ClassAdmins");
                });

            modelBuilder.Entity("Domain.Entities.FSU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FSUs");
                });

            modelBuilder.Entity("Domain.Entities.OutputStandard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OutputStandards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "SBCM",
                            Description = "Removal of Radioactive Element from Right Pleural Cavity, Percutaneous Approach",
                            IsDeleted = false,
                            Title = "Island Brittleleaf"
                        },
                        new
                        {
                            Id = 2,
                            Code = "ZSJD",
                            Description = "Supplement Left Lacrimal Duct with Autologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic",
                            IsDeleted = false,
                            Title = "Rod Wirelettuce"
                        },
                        new
                        {
                            Id = 3,
                            Code = "KMWL",
                            Description = "Excision of Right Neck Muscle, Percutaneous Endoscopic Approach, Diagnostic",
                            IsDeleted = false,
                            Title = "Gila Globemallow"
                        },
                        new
                        {
                            Id = 4,
                            Code = "ZGKL",
                            Description = "Repair Left Internal Mammary Artery, Open Approach",
                            IsDeleted = false,
                            Title = "Hawthorn"
                        },
                        new
                        {
                            Id = 5,
                            Code = "UTNN",
                            Description = "Excision of Right Frontal Bone, Percutaneous Endoscopic Approach, Diagnostic",
                            IsDeleted = false,
                            Title = "Muir's Fleabane"
                        },
                        new
                        {
                            Id = 6,
                            Code = "SSPG",
                            Description = "Nonimaging Nuclear Medicine Probe of Abdomen and Pelvis using Indium 111 (In-111)",
                            IsDeleted = false,
                            Title = "Creeping Marshwort"
                        },
                        new
                        {
                            Id = 7,
                            Code = "DBBB",
                            Description = "Supplement Right Thumb Phalanx with Autologous Tissue Substitute, Percutaneous Approach",
                            IsDeleted = false,
                            Title = "Douglas-fir"
                        },
                        new
                        {
                            Id = 8,
                            Code = "ORQW",
                            Description = "Alteration of Head with Nonautologous Tissue Substitute, Percutaneous Approach",
                            IsDeleted = false,
                            Title = "Tiny Pea"
                        },
                        new
                        {
                            Id = 9,
                            Code = "HKLU",
                            Description = "Dilation of Left Peroneal Artery, Bifurcation, Percutaneous Approach",
                            IsDeleted = false,
                            Title = "Large Camas"
                        },
                        new
                        {
                            Id = 10,
                            Code = "RJSS",
                            Description = "Restriction of Superior Mesenteric Vein with Intraluminal Device, Percutaneous Endoscopic Approach",
                            IsDeleted = false,
                            Title = "Flatsedge"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ProgramSyllabus", b =>
                {
                    b.Property<int>("SyllabusId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SyllabusId", "TrainingProgramId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("ProgramSyllabuses");
                });

            modelBuilder.Entity("Domain.Entities.StudentAssignment", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("AssignmentFileLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGraded")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Score")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeSubmit")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId", "AssignmentId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("StudentAssignments");
                });

            modelBuilder.Entity("Domain.Entities.Syllabus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentSchema")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseObjective")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FinalPracticeSchema")
                        .HasColumnType("int");

                    b.Property<int>("FinalSchema")
                        .HasColumnType("int");

                    b.Property<int>("FinalTheorySchema")
                        .HasColumnType("int");

                    b.Property<int>("GPASchema")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizSchema")
                        .HasColumnType("int");

                    b.Property<int>("SyllabusLevel")
                        .HasColumnType("int");

                    b.Property<string>("TechnicalRequirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingDeliveryPrinciple")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Version")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Syllabuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignmentSchema = 0,
                            AttendeeNumber = 30,
                            Code = "IDR",
                            CourseObjective = "Insert Infusion Dev in Prostate/Seminal Ves, Open",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Miller Buncombe",
                            QuizSchema = 15,
                            SyllabusLevel = 3,
                            TechnicalRequirement = "Extirpation of Matter from Left Tibia, Percutaneous Endoscopic Approach",
                            TrainingDeliveryPrinciple = "Extirpation of Matter from Left Tibia, Perc Endo Approach",
                            Version = 1f
                        },
                        new
                        {
                            Id = 2,
                            AssignmentSchema = 0,
                            AttendeeNumber = 26,
                            Code = "EUR",
                            CourseObjective = "Dilate R Int Iliac Art, Bifurc, w 3 Intralum Dev, Perc Endo",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Fielding Matzaitis",
                            QuizSchema = 15,
                            SyllabusLevel = 3,
                            TechnicalRequirement = "Dilation of Right Common Iliac Artery, Bifurcation, with Two Drug-eluting Intraluminal Devices, Percutaneous Endoscopic Approach",
                            TrainingDeliveryPrinciple = "Dilate R Com Iliac Art, Bifurc, w 2 Drug-elut, Perc Endo",
                            Version = 1f
                        },
                        new
                        {
                            Id = 3,
                            AssignmentSchema = 0,
                            AttendeeNumber = 22,
                            Code = "PHP",
                            CourseObjective = "Plain Radiography of R Salivary Gland using H Osm Contrast",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Timmie Crossfield",
                            QuizSchema = 15,
                            SyllabusLevel = 1,
                            TechnicalRequirement = "Supplement Left Hand Bursa and Ligament with Synthetic Substitute, Percutaneous Endoscopic Approach",
                            TrainingDeliveryPrinciple = "Supplement L Hand Bursa/Lig w Synth Sub, Perc Endo",
                            Version = 1f
                        },
                        new
                        {
                            Id = 4,
                            AssignmentSchema = 0,
                            AttendeeNumber = 21,
                            Code = "IDR",
                            CourseObjective = "HDR Brachytherapy of Pleura using Palladium 103",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Selinda Yurmanovev",
                            QuizSchema = 15,
                            SyllabusLevel = 3,
                            TechnicalRequirement = "Excision of Left Atrial Appendage, Open Approach",
                            TrainingDeliveryPrinciple = "Excision of Left Atrial Appendage, Open Approach",
                            Version = 1f
                        },
                        new
                        {
                            Id = 5,
                            AssignmentSchema = 0,
                            AttendeeNumber = 29,
                            Code = "JPY",
                            CourseObjective = "Reposition Right Carpal Joint, External Approach",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Charla MacTurlough",
                            QuizSchema = 15,
                            SyllabusLevel = 2,
                            TechnicalRequirement = "Osteopathic Treatment of Cervical Region using Muscle Energy-Isotonic Forces",
                            TrainingDeliveryPrinciple = "Osteopathic Treatment Cervcal Region w Muscle Isotonic",
                            Version = 1f
                        },
                        new
                        {
                            Id = 6,
                            AssignmentSchema = 0,
                            AttendeeNumber = 24,
                            Code = "RUB",
                            CourseObjective = "Supplement R Temporomandib Jt with Synth Sub, Perc Approach",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Heather Fomichkin",
                            QuizSchema = 15,
                            SyllabusLevel = 2,
                            TechnicalRequirement = "Dilation of Lower Vein, Open Approach",
                            TrainingDeliveryPrinciple = "Dilation of Lower Vein, Open Approach",
                            Version = 1f
                        },
                        new
                        {
                            Id = 7,
                            AssignmentSchema = 0,
                            AttendeeNumber = 22,
                            Code = "THB",
                            CourseObjective = "Change Drainage Device in Uterus and Cervix, Extern Approach",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Fern Waylen",
                            QuizSchema = 15,
                            SyllabusLevel = 2,
                            TechnicalRequirement = "Drainage of Left Palatine Bone, Percutaneous Approach",
                            TrainingDeliveryPrinciple = "Drainage of Left Palatine Bone, Percutaneous Approach",
                            Version = 1f
                        },
                        new
                        {
                            Id = 8,
                            AssignmentSchema = 0,
                            AttendeeNumber = 29,
                            Code = "USD",
                            CourseObjective = "Replace of R Zygomatic Bone with Synth Sub, Open Approach",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Anthony Minucci",
                            QuizSchema = 15,
                            SyllabusLevel = 3,
                            TechnicalRequirement = "Extirpation of Matter from Right Renal Artery, Bifurcation, Open Approach",
                            TrainingDeliveryPrinciple = "Extirpate of Matter from R Renal Art, Bifurc, Open Approach",
                            Version = 1f
                        },
                        new
                        {
                            Id = 9,
                            AssignmentSchema = 0,
                            AttendeeNumber = 30,
                            Code = "CNY",
                            CourseObjective = "Beam Radiation of Hypopharynx using Neutrons",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Caldwell Nickels",
                            QuizSchema = 15,
                            SyllabusLevel = 3,
                            TechnicalRequirement = "Dilation of Left Peroneal Artery, Bifurcation, with Intraluminal Device, Percutaneous Endoscopic Approach",
                            TrainingDeliveryPrinciple = "Dilate L Peroneal Art, Bifurc, w Intralum Dev, Perc Endo",
                            Version = 1f
                        },
                        new
                        {
                            Id = 10,
                            AssignmentSchema = 0,
                            AttendeeNumber = 20,
                            Code = "PLN",
                            CourseObjective = "Destruction of Cerebellum, Percutaneous Endoscopic Approach",
                            FinalPracticeSchema = 0,
                            FinalSchema = 70,
                            FinalTheorySchema = 40,
                            GPASchema = 70,
                            IsDeleted = false,
                            Name = "Galven Muehler",
                            QuizSchema = 15,
                            SyllabusLevel = 2,
                            TechnicalRequirement = "Occlusion of Left Axillary Artery, Percutaneous Approach",
                            TrainingDeliveryPrinciple = "Occlusion of Left Axillary Artery, Percutaneous Approach",
                            Version = 1f
                        });
                });

            modelBuilder.Entity("Domain.Entities.TrainingClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("AttendeeType")
                        .HasColumnType("int");

                    b.Property<string>("ClassCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassLocation")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ClassTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClassTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FSUId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberAttendeeAccepted")
                        .HasColumnType("int");

                    b.Property<int>("NumberAttendeeActual")
                        .HasColumnType("int");

                    b.Property<int>("NumberAttendeePlanned")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("int");

                    b.Property<int?>("UserApprovedId")
                        .HasColumnType("int");

                    b.Property<int?>("UserReviewedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FSUId");

                    b.HasIndex("TrainingProgramId")
                        .IsUnique();

                    b.ToTable("TrainingClasses");
                });

            modelBuilder.Entity("Domain.Entities.TrainingMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnitLessonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitLessonId");

                    b.ToTable("TrainingMaterials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FileLink = "http://dummyimage.com/112x100.png/dddddd/000000",
                            FileName = "LectusInQuam.ppt",
                            IsDeleted = false,
                            UnitLessonId = 1
                        },
                        new
                        {
                            Id = 2,
                            FileLink = "http://dummyimage.com/193x100.png/5fa2dd/ffffff",
                            FileName = "EnimBlandit.xls",
                            IsDeleted = false,
                            UnitLessonId = 1
                        },
                        new
                        {
                            Id = 3,
                            FileLink = "http://dummyimage.com/181x100.png/cc0000/ffffff",
                            FileName = "MattisOdio.avi",
                            IsDeleted = false,
                            UnitLessonId = 1
                        },
                        new
                        {
                            Id = 4,
                            FileLink = "http://dummyimage.com/210x100.png/cc0000/ffffff",
                            FileName = "DictumstMorbiVestibulum.avi",
                            IsDeleted = false,
                            UnitLessonId = 2
                        },
                        new
                        {
                            Id = 5,
                            FileLink = "http://dummyimage.com/131x100.png/cc0000/ffffff",
                            FileName = "Nascetur.mp3",
                            IsDeleted = false,
                            UnitLessonId = 2
                        },
                        new
                        {
                            Id = 6,
                            FileLink = "http://dummyimage.com/169x100.png/dddddd/000000",
                            FileName = "Eu.mp3",
                            IsDeleted = false,
                            UnitLessonId = 3
                        },
                        new
                        {
                            Id = 7,
                            FileLink = "http://dummyimage.com/102x100.png/cc0000/ffffff",
                            FileName = "PosuereCubiliaCurae.xls",
                            IsDeleted = false,
                            UnitLessonId = 4
                        },
                        new
                        {
                            Id = 8,
                            FileLink = "http://dummyimage.com/168x100.png/cc0000/ffffff",
                            FileName = "Adipiscing.avi",
                            IsDeleted = false,
                            UnitLessonId = 5
                        },
                        new
                        {
                            Id = 9,
                            FileLink = "http://dummyimage.com/224x100.png/ff4444/ffffff",
                            FileName = "SitAmetSapien.ppt",
                            IsDeleted = false,
                            UnitLessonId = 6
                        },
                        new
                        {
                            Id = 10,
                            FileLink = "http://dummyimage.com/214x100.png/cc0000/ffffff",
                            FileName = "Sociis.mpeg",
                            IsDeleted = false,
                            UnitLessonId = 7
                        });
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("SyllabusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SyllabusId");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Day = 1,
                            IsDeleted = false,
                            Name = "Gembucket",
                            SortOrder = 1,
                            SyllabusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Day = 2,
                            IsDeleted = false,
                            Name = "Daltfresh",
                            SortOrder = 2,
                            SyllabusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Day = 3,
                            IsDeleted = false,
                            Name = "Asoka",
                            SortOrder = 3,
                            SyllabusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Day = 4,
                            IsDeleted = false,
                            Name = "Treeflex",
                            SortOrder = 4,
                            SyllabusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Day = 1,
                            IsDeleted = false,
                            Name = "It",
                            SortOrder = 1,
                            SyllabusId = 2
                        },
                        new
                        {
                            Id = 6,
                            Day = 2,
                            IsDeleted = false,
                            Name = "Gembucket",
                            SortOrder = 2,
                            SyllabusId = 2
                        },
                        new
                        {
                            Id = 7,
                            Day = 3,
                            IsDeleted = false,
                            Name = "Bitwolf",
                            SortOrder = 3,
                            SyllabusId = 2
                        },
                        new
                        {
                            Id = 8,
                            Day = 4,
                            IsDeleted = false,
                            Name = "Treeflex",
                            SortOrder = 4,
                            SyllabusId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.UnitClassDetail", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "UnitId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("UnitId");

                    b.ToTable("UnitClassDetails");
                });

            modelBuilder.Entity("Domain.Entities.UnitClassLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuildingLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitClassLocations");
                });

            modelBuilder.Entity("Domain.Entities.UnitLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryType")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LessonType")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OutputStandardId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OutputStandardId");

                    b.HasIndex("UnitId");

                    b.ToTable("UnitLessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeliveryType = 0,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 0,
                            Name = "Lupinus chamissonis Eschsch.",
                            OutputStandardId = 1,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeliveryType = 1,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 0,
                            Name = "Jamesia americana Torr. & A. Gray var. macrocalyx (Small) Engl.",
                            OutputStandardId = 2,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 3,
                            DeliveryType = 4,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 0,
                            Name = "Dasylirion leiophyllum Engelm. ex Trel.",
                            OutputStandardId = 3,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 4,
                            DeliveryType = 4,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 1,
                            Name = "Rayjacksonia phyllocephala (DC.) R.L. Hartm. & M.A. Lane",
                            OutputStandardId = 4,
                            UnitId = 2
                        },
                        new
                        {
                            Id = 5,
                            DeliveryType = 4,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 1,
                            Name = "Coccotrema Müll. Arg.",
                            OutputStandardId = 5,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 6,
                            DeliveryType = 5,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 1,
                            Name = "Rubus ulmifolius Schott",
                            OutputStandardId = 6,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 7,
                            DeliveryType = 0,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 1,
                            Name = "Pseudolmedia Trécul",
                            OutputStandardId = 7,
                            UnitId = 1
                        },
                        new
                        {
                            Id = 8,
                            DeliveryType = 5,
                            Duration = 60,
                            IsDeleted = false,
                            LessonType = 1,
                            Name = "Alchemilla wichurae (Buser) Stefansson",
                            OutputStandardId = 8,
                            UnitId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(4);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassAccessPermission")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LearningMaterialAccessPermission")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleType")
                        .HasColumnType("int");

                    b.Property<int>("SyllabusAccessPermission")
                        .HasColumnType("int");

                    b.Property<int>("TrainingProgramAccessPermission")
                        .HasColumnType("int");

                    b.Property<int>("UserAccessPermission")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.Property<int>("TrainingClassId")
                        .HasColumnType("int");

                    b.HasIndex("TrainingClassId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.HasOne("Domain.Entities.Syllabus", "Syllabus")
                        .WithMany("Assignments")
                        .HasForeignKey("SyllabusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingClass", "TrainingClass")
                        .WithMany("Assignments")
                        .HasForeignKey("TrainingClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Syllabus");

                    b.Navigation("TrainingClass");
                });

            modelBuilder.Entity("Domain.Entities.ClassAdmin", b =>
                {
                    b.HasOne("Domain.Entities.TrainingClass", "TrainingClass")
                        .WithMany("Admins")
                        .HasForeignKey("TrainingClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("ClassAdmins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingClass");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.ProgramSyllabus", b =>
                {
                    b.HasOne("Domain.Entities.Syllabus", "Syllabus")
                        .WithMany("ProgramSyllabuses")
                        .HasForeignKey("SyllabusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("ProgramSyllabuses")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Syllabus");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.StudentAssignment", b =>
                {
                    b.HasOne("Domain.Entities.Assignment", "Assignment")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Entities.TrainingClass", b =>
                {
                    b.HasOne("Domain.Entities.FSU", "FSU")
                        .WithMany("TrainingClasses")
                        .HasForeignKey("FSUId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithOne("TrainingClass")
                        .HasForeignKey("Domain.Entities.TrainingClass", "TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FSU");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.TrainingMaterial", b =>
                {
                    b.HasOne("Domain.Entities.UnitLesson", "UnitLesson")
                        .WithMany("TrainingMaterials")
                        .HasForeignKey("UnitLessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitLesson");
                });

            modelBuilder.Entity("Domain.Entities.Unit", b =>
                {
                    b.HasOne("Domain.Entities.Syllabus", "Syllabus")
                        .WithMany("Units")
                        .HasForeignKey("SyllabusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Syllabus");
                });

            modelBuilder.Entity("Domain.Entities.UnitClassDetail", b =>
                {
                    b.HasOne("Domain.Entities.TrainingClass", "TrainingClass")
                        .WithMany("UnitClassDetails")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UnitClassLocation", "Location")
                        .WithMany("UnitClassDetailLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Trainer")
                        .WithMany("UnitClassDetails")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Unit", "Unit")
                        .WithMany("UnitClassDetails")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Trainer");

                    b.Navigation("TrainingClass");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Domain.Entities.UnitLesson", b =>
                {
                    b.HasOne("Domain.Entities.OutputStandard", "OutputStandard")
                        .WithMany("UnitLessons")
                        .HasForeignKey("OutputStandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Unit", "Unit")
                        .WithMany("UnitLessons")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OutputStandard");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasOne("Domain.Entities.TrainingClass", "TrainingClass")
                        .WithMany("Students")
                        .HasForeignKey("TrainingClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("TrainingClass");
                });

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.Navigation("StudentAssignments");
                });

            modelBuilder.Entity("Domain.Entities.FSU", b =>
                {
                    b.Navigation("TrainingClasses");
                });

            modelBuilder.Entity("Domain.Entities.OutputStandard", b =>
                {
                    b.Navigation("UnitLessons");
                });

            modelBuilder.Entity("Domain.Entities.Syllabus", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("ProgramSyllabuses");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Domain.Entities.TrainingClass", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Assignments");

                    b.Navigation("Students");

                    b.Navigation("UnitClassDetails");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Navigation("ProgramSyllabuses");

                    b.Navigation("TrainingClass")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Unit", b =>
                {
                    b.Navigation("UnitClassDetails");

                    b.Navigation("UnitLessons");
                });

            modelBuilder.Entity("Domain.Entities.UnitClassLocation", b =>
                {
                    b.Navigation("UnitClassDetailLocations");
                });

            modelBuilder.Entity("Domain.Entities.UnitLesson", b =>
                {
                    b.Navigation("TrainingMaterials");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("ClassAdmins");

                    b.Navigation("UnitClassDetails");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Navigation("StudentAssignments");
                });
        }
    }
}
