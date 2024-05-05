
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FSUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FSUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutputStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutputStandards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Syllabuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingDeliveryPrinciple = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SyllabusLevel = table.Column<int>(type: "int", nullable: false),
                    AttendeeNumber = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TechnicalRequirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseObjective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<float>(type: "real", nullable: false),
                    QuizSchema = table.Column<int>(type: "int", nullable: false),
                    AssignmentSchema = table.Column<int>(type: "int", nullable: false),
                    FinalSchema = table.Column<int>(type: "int", nullable: false),
                    FinalTheorySchema = table.Column<int>(type: "int", nullable: false),
                    FinalPracticeSchema = table.Column<int>(type: "int", nullable: false),
                    GPASchema = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syllabuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitClassLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitClassLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    SyllabusAccessPermission = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramAccessPermission = table.Column<int>(type: "int", nullable: false),
                    ClassAccessPermission = table.Column<int>(type: "int", nullable: false),
                    LearningMaterialAccessPermission = table.Column<int>(type: "int", nullable: false),
                    UserAccessPermission = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    SyllabusId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Syllabuses_SyllabusId",
                        column: x => x.SyllabusId,
                        principalTable: "Syllabuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramSyllabuses",
                columns: table => new
                {
                    SyllabusId = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramSyllabuses", x => new { x.SyllabusId, x.TrainingProgramId });
                    table.ForeignKey(
                        name: "FK_ProgramSyllabuses_Syllabuses_SyllabusId",
                        column: x => x.SyllabusId,
                        principalTable: "Syllabuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramSyllabuses_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassLocation = table.Column<int>(type: "int", nullable: false),
                    ClassTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ReviewedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserReviewedId = table.Column<int>(type: "int", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserApprovedId = table.Column<int>(type: "int", nullable: true),
                    AttendeeType = table.Column<int>(type: "int", nullable: false),
                    NumberAttendeePlanned = table.Column<int>(type: "int", nullable: false),
                    NumberAttendeeAccepted = table.Column<int>(type: "int", nullable: false),
                    NumberAttendeeActual = table.Column<int>(type: "int", nullable: false),
                    FSUId = table.Column<int>(type: "int", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingClasses_FSUs_FSUId",
                        column: x => x.FSUId,
                        principalTable: "FSUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingClasses_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    LessonType = table.Column<int>(type: "int", nullable: false),
                    DeliveryType = table.Column<int>(type: "int", nullable: false),
                    OutputStandardId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitLessons_OutputStandards_OutputStandardId",
                        column: x => x.OutputStandardId,
                        principalTable: "OutputStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitLessons_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingClassId = table.Column<int>(type: "int", nullable: false),
                    SyllabusId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Syllabuses_SyllabusId",
                        column: x => x.SyllabusId,
                        principalTable: "Syllabuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_TrainingClasses_TrainingClassId",
                        column: x => x.TrainingClassId,
                        principalTable: "TrainingClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 3),
                    Role = table.Column<int>(type: "int", nullable: false, defaultValue: 4),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_TrainingClasses_TrainingClassId",
                        column: x => x.TrainingClassId,
                        principalTable: "TrainingClasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitLessonId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingMaterials_UnitLessons_UnitLessonId",
                        column: x => x.UnitLessonId,
                        principalTable: "UnitLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassAdmins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrainingClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAdmins", x => new { x.UserId, x.TrainingClassId });
                    table.ForeignKey(
                        name: "FK_ClassAdmins_TrainingClasses_TrainingClassId",
                        column: x => x.TrainingClassId,
                        principalTable: "TrainingClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassAdmins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAssignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    TimeSubmit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsGraded = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AssignmentFileLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignments", x => new { x.StudentId, x.AssignmentId });
                    table.ForeignKey(
                        name: "FK_StudentAssignments_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAssignments_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitClassDetails",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitClassDetails", x => new { x.ClassId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_UnitClassDetails_TrainingClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "TrainingClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitClassDetails_UnitClassLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "UnitClassLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitClassDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitClassDetails_Users_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OutputStandards",
                columns: new[] { "Id", "Code", "CreatedByUserId", "CreatedOn", "Description", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Title" },
                values: new object[,]
                {
                    { 1, "SBCM", null, null, "Removal of Radioactive Element from Right Pleural Cavity, Percutaneous Approach", false, null, null, "Island Brittleleaf" },
                    { 2, "ZSJD", null, null, "Supplement Left Lacrimal Duct with Autologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic", false, null, null, "Rod Wirelettuce" },
                    { 3, "KMWL", null, null, "Excision of Right Neck Muscle, Percutaneous Endoscopic Approach, Diagnostic", false, null, null, "Gila Globemallow" },
                    { 4, "ZGKL", null, null, "Repair Left Internal Mammary Artery, Open Approach", false, null, null, "Hawthorn" },
                    { 5, "UTNN", null, null, "Excision of Right Frontal Bone, Percutaneous Endoscopic Approach, Diagnostic", false, null, null, "Muir's Fleabane" },
                    { 6, "SSPG", null, null, "Nonimaging Nuclear Medicine Probe of Abdomen and Pelvis using Indium 111 (In-111)", false, null, null, "Creeping Marshwort" },
                    { 7, "DBBB", null, null, "Supplement Right Thumb Phalanx with Autologous Tissue Substitute, Percutaneous Approach", false, null, null, "Douglas-fir" },
                    { 8, "ORQW", null, null, "Alteration of Head with Nonautologous Tissue Substitute, Percutaneous Approach", false, null, null, "Tiny Pea" },
                    { 9, "HKLU", null, null, "Dilation of Left Peroneal Artery, Bifurcation, Percutaneous Approach", false, null, null, "Large Camas" },
                    { 10, "RJSS", null, null, "Restriction of Superior Mesenteric Vein with Intraluminal Device, Percutaneous Endoscopic Approach", false, null, null, "Flatsedge" }
                });

            migrationBuilder.InsertData(
                table: "Syllabuses",
                columns: new[] { "Id", "AssignmentSchema", "AttendeeNumber", "Code", "CourseObjective", "CreatedByUserId", "CreatedOn", "FinalPracticeSchema", "FinalSchema", "FinalTheorySchema", "GPASchema", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "QuizSchema", "SyllabusLevel", "TechnicalRequirement", "TrainingDeliveryPrinciple", "Version" },
                values: new object[,]
                {
                    { 1, 0, 30, "IDR", "Insert Infusion Dev in Prostate/Seminal Ves, Open", null, null, 0, 70, 40, 70, false, null, null, "Miller Buncombe", 15, 3, "Extirpation of Matter from Left Tibia, Percutaneous Endoscopic Approach", "Extirpation of Matter from Left Tibia, Perc Endo Approach", 1f },
                    { 2, 0, 26, "EUR", "Dilate R Int Iliac Art, Bifurc, w 3 Intralum Dev, Perc Endo", null, null, 0, 70, 40, 70, false, null, null, "Fielding Matzaitis", 15, 3, "Dilation of Right Common Iliac Artery, Bifurcation, with Two Drug-eluting Intraluminal Devices, Percutaneous Endoscopic Approach", "Dilate R Com Iliac Art, Bifurc, w 2 Drug-elut, Perc Endo", 1f },
                    { 3, 0, 22, "PHP", "Plain Radiography of R Salivary Gland using H Osm Contrast", null, null, 0, 70, 40, 70, false, null, null, "Timmie Crossfield", 15, 1, "Supplement Left Hand Bursa and Ligament with Synthetic Substitute, Percutaneous Endoscopic Approach", "Supplement L Hand Bursa/Lig w Synth Sub, Perc Endo", 1f },
                    { 4, 0, 21, "IDR", "HDR Brachytherapy of Pleura using Palladium 103", null, null, 0, 70, 40, 70, false, null, null, "Selinda Yurmanovev", 15, 3, "Excision of Left Atrial Appendage, Open Approach", "Excision of Left Atrial Appendage, Open Approach", 1f },
                    { 5, 0, 29, "JPY", "Reposition Right Carpal Joint, External Approach", null, null, 0, 70, 40, 70, false, null, null, "Charla MacTurlough", 15, 2, "Osteopathic Treatment of Cervical Region using Muscle Energy-Isotonic Forces", "Osteopathic Treatment Cervcal Region w Muscle Isotonic", 1f },
                    { 6, 0, 24, "RUB", "Supplement R Temporomandib Jt with Synth Sub, Perc Approach", null, null, 0, 70, 40, 70, false, null, null, "Heather Fomichkin", 15, 2, "Dilation of Lower Vein, Open Approach", "Dilation of Lower Vein, Open Approach", 1f },
                    { 7, 0, 22, "THB", "Change Drainage Device in Uterus and Cervix, Extern Approach", null, null, 0, 70, 40, 70, false, null, null, "Fern Waylen", 15, 2, "Drainage of Left Palatine Bone, Percutaneous Approach", "Drainage of Left Palatine Bone, Percutaneous Approach", 1f },
                    { 8, 0, 29, "USD", "Replace of R Zygomatic Bone with Synth Sub, Open Approach", null, null, 0, 70, 40, 70, false, null, null, "Anthony Minucci", 15, 3, "Extirpation of Matter from Right Renal Artery, Bifurcation, Open Approach", "Extirpate of Matter from R Renal Art, Bifurc, Open Approach", 1f },
                    { 9, 0, 30, "CNY", "Beam Radiation of Hypopharynx using Neutrons", null, null, 0, 70, 40, 70, false, null, null, "Caldwell Nickels", 15, 3, "Dilation of Left Peroneal Artery, Bifurcation, with Intraluminal Device, Percutaneous Endoscopic Approach", "Dilate L Peroneal Art, Bifurc, w Intralum Dev, Perc Endo", 1f },
                    { 10, 0, 20, "PLN", "Destruction of Cerebellum, Percutaneous Endoscopic Approach", null, null, 0, 70, 40, 70, false, null, null, "Galven Muehler", 15, 2, "Occlusion of Left Axillary Artery, Percutaneous Approach", "Occlusion of Left Axillary Artery, Percutaneous Approach", 1f }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "Day", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "Name", "SortOrder", "SyllabusId" },
                values: new object[,]
                {
                    { 1, null, null, 1, false, null, null, "Gembucket", 1, 1 },
                    { 2, null, null, 2, false, null, null, "Daltfresh", 2, 1 },
                    { 3, null, null, 3, false, null, null, "Asoka", 3, 1 },
                    { 4, null, null, 4, false, null, null, "Treeflex", 4, 1 },
                    { 5, null, null, 1, false, null, null, "It", 1, 2 },
                    { 6, null, null, 2, false, null, null, "Gembucket", 2, 2 },
                    { 7, null, null, 3, false, null, null, "Bitwolf", 3, 2 },
                    { 8, null, null, 4, false, null, null, "Treeflex", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "UnitLessons",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "DeliveryType", "Duration", "IsDeleted", "LessonType", "ModifiedByUserId", "ModifiedOn", "Name", "OutputStandardId", "UnitId" },
                values: new object[,]
                {
                    { 1, null, null, 0, 60, false, 0, null, null, "Lupinus chamissonis Eschsch.", 1, 1 },
                    { 2, null, null, 1, 60, false, 0, null, null, "Jamesia americana Torr. & A. Gray var. macrocalyx (Small) Engl.", 2, 1 },
                    { 3, null, null, 4, 60, false, 0, null, null, "Dasylirion leiophyllum Engelm. ex Trel.", 3, 1 },
                    { 4, null, null, 4, 60, false, 1, null, null, "Rayjacksonia phyllocephala (DC.) R.L. Hartm. & M.A. Lane", 4, 2 },
                    { 5, null, null, 4, 60, false, 1, null, null, "Coccotrema Müll. Arg.", 5, 1 },
                    { 6, null, null, 5, 60, false, 1, null, null, "Rubus ulmifolius Schott", 6, 1 },
                    { 7, null, null, 0, 60, false, 1, null, null, "Pseudolmedia Trécul", 7, 1 },
                    { 8, null, null, 5, 60, false, 1, null, null, "Alchemilla wichurae (Buser) Stefansson", 8, 2 }
                });

            migrationBuilder.InsertData(
                table: "TrainingMaterials",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "FileLink", "FileName", "IsDeleted", "ModifiedByUserId", "ModifiedOn", "UnitLessonId" },
                values: new object[,]
                {
                    { 1, null, null, "http://dummyimage.com/112x100.png/dddddd/000000", "LectusInQuam.ppt", false, null, null, 1 },
                    { 2, null, null, "http://dummyimage.com/193x100.png/5fa2dd/ffffff", "EnimBlandit.xls", false, null, null, 1 },
                    { 3, null, null, "http://dummyimage.com/181x100.png/cc0000/ffffff", "MattisOdio.avi", false, null, null, 1 },
                    { 4, null, null, "http://dummyimage.com/210x100.png/cc0000/ffffff", "DictumstMorbiVestibulum.avi", false, null, null, 2 },
                    { 5, null, null, "http://dummyimage.com/131x100.png/cc0000/ffffff", "Nascetur.mp3", false, null, null, 2 },
                    { 6, null, null, "http://dummyimage.com/169x100.png/dddddd/000000", "Eu.mp3", false, null, null, 3 },
                    { 7, null, null, "http://dummyimage.com/102x100.png/cc0000/ffffff", "PosuereCubiliaCurae.xls", false, null, null, 4 },
                    { 8, null, null, "http://dummyimage.com/168x100.png/cc0000/ffffff", "Adipiscing.avi", false, null, null, 5 },
                    { 9, null, null, "http://dummyimage.com/224x100.png/ff4444/ffffff", "SitAmetSapien.ppt", false, null, null, 6 },
                    { 10, null, null, "http://dummyimage.com/214x100.png/cc0000/ffffff", "Sociis.mpeg", false, null, null, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_SyllabusId",
                table: "Assignments",
                column: "SyllabusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_TrainingClassId",
                table: "Assignments",
                column: "TrainingClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAdmins_TrainingClassId",
                table: "ClassAdmins",
                column: "TrainingClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramSyllabuses_TrainingProgramId",
                table: "ProgramSyllabuses",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignments_AssignmentId",
                table: "StudentAssignments",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingClasses_FSUId",
                table: "TrainingClasses",
                column: "FSUId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingClasses_TrainingProgramId",
                table: "TrainingClasses",
                column: "TrainingProgramId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingMaterials_UnitLessonId",
                table: "TrainingMaterials",
                column: "UnitLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitClassDetails_LocationId",
                table: "UnitClassDetails",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitClassDetails_TrainerId",
                table: "UnitClassDetails",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitClassDetails_UnitId",
                table: "UnitClassDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitLessons_OutputStandardId",
                table: "UnitLessons",
                column: "OutputStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitLessons_UnitId",
                table: "UnitLessons",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_SyllabusId",
                table: "Units",
                column: "SyllabusId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrainingClassId",
                table: "Users",
                column: "TrainingClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassAdmins");

            migrationBuilder.DropTable(
                name: "ProgramSyllabuses");

            migrationBuilder.DropTable(
                name: "StudentAssignments");

            migrationBuilder.DropTable(
                name: "TrainingMaterials");

            migrationBuilder.DropTable(
                name: "UnitClassDetails");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "UnitLessons");

            migrationBuilder.DropTable(
                name: "UnitClassLocations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "OutputStandards");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "TrainingClasses");

            migrationBuilder.DropTable(
                name: "Syllabuses");

            migrationBuilder.DropTable(
                name: "FSUs");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");
        }
    }
}

